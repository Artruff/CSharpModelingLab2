using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpModelingLab2.Classes;

namespace CSharpModelingLab2
{
    public partial class Quarrr : Form
    {
        WorldModel world;
        QuarryModel quarry;
        public Quarrr()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            DumpTrackModel track = new DumpTrackModel(20, 1.5, 2.5, 5, 2, "1");

            QuarryModel quarry = new QuarryModel("1");

            ExcavatorModel excavator1 = new ExcavatorModel("1", quarry);
            ExcavatorModel excavator2 = new ExcavatorModel("2", quarry);
            ExcavatorModel excavator3 = new ExcavatorModel("3", quarry);

            WorldModel worldModel = new WorldModel("1");
            worldModel.AddPlace(excavator1);
            //worldModel.AddPlace(excavator2);
            //worldModel.AddPlace(excavator3);
            worldModel.AddPlace(quarry);

            excavator1.AddCar(track);

            worldModel.Tick();
            worldModel.Tick();
            worldModel.Tick(); 
            worldModel.Tick();
            worldModel.Tick();
        }

        private void TickButton_Click(object sender, EventArgs e)
        {
            if (world == null)
                InitWorld();
            world.Tick();
        }
        private void InitWorld()
        {
            world = new WorldModel("моделируемый мир");

            world.NewAction += delegate (double time)
            {
                GlobalTime.Text = world.globalTime.ToString();
            };

            quarry = new QuarryModel("главный");
            world.AddPlace(quarry);
            //quarry.CarArrived += delegate (Interfaces.IModelingCar car)
            //{
            //    LogBox.Items.Add(world.globalTime + ":" + car.statiscticCreater.name + " въехал на территорию карьера " + quarry.statiscticCreater.name);
            //};

            AddExcToWorld("первый", FirstExDataGridView);
            AddExcToWorld("второй", SecondExDataGridView);
            AddExcToWorld("третий", ThirdExDataGridView);
        }

        private void AddExcToWorld(string name, DataGridView dataGridView)
        {
            ExcavatorModel excavator = new ExcavatorModel(name, quarry);
            excavator.CarArrived += delegate (Interfaces.IModelingCar car)
            {
                LogBox.Items.Add(world.globalTime + ":" + car.statiscticCreater.name + " прибыл к экскаватору " + excavator.statiscticCreater.name);
            };

            world.AddPlace(excavator);
            double weight, toExc, toQua, load, upload;
            string nameTrack;
            for (int i = 0; i< dataGridView.Rows.Count-1; i++)
            {
                nameTrack = dataGridView[0, i].Value.ToString();
                weight = Convert.ToDouble(dataGridView[1, i].Value.ToString());
                toExc = Convert.ToDouble(dataGridView[2, i].Value.ToString());
                toQua = Convert.ToDouble(dataGridView[3, i].Value.ToString());
                load = Convert.ToDouble(dataGridView[4, i].Value.ToString());
                upload = Convert.ToDouble(dataGridView[5, i].Value.ToString());
                DumpTrackModel track = new DumpTrackModel(weight, toExc, toQua, load, upload, nameTrack);

                track.Loading += delegate (double time) 
                { 
                    LogBox.Items.Add(world.globalTime + ":" + track.statiscticCreater.name + " загрузится через " + time); 
                };
                track.Ride += delegate (double time) 
                {
                    if (track.status == Interfaces.StatusCar.GoesToQuarry)
                    {
                        LogBox.Items.Add(world.globalTime + ":" + track.statiscticCreater.name + " доедет до карьера через " + time);
                    }
                    else
                    {
                        LogBox.Items.Add(world.globalTime + ":" + track.statiscticCreater.name + " доедет до экскаватора через " + time);
                    }
                };
                track.Shipment += delegate (double time) { LogBox.Items.Add(world.globalTime + ":" + track.statiscticCreater.name + " разгрузится через " + time); };
                
                excavator.AddCar(track);
            }

        }

        private void statButton_Click(object sender, EventArgs e)
        {
            var info = world.GetInfo();

            foreach (string inf in info)
                LogBox.Items.Add(inf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (world == null)
                InitWorld();
            while (world.globalTime < Convert.ToDouble(CountTexBox.Text))
                world.Tick();
        }
    }
}
