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
    public partial class MainWindow : Form
    {
        WorldModel world;
        QuarryModel quarry;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            DumpTrackModel track = new DumpTrackModel(20, 1.5, 2.5, 5, 2, "1");

            QuarryModel quarry = new QuarryModel(new QuarryStatisticCreator());

            ExcavatorModel excavator1 = new ExcavatorModel(new ExcavatorStatisticCreator(), quarry);
            ExcavatorModel excavator2 = new ExcavatorModel(new ExcavatorStatisticCreator(), quarry);
            ExcavatorModel excavator3 = new ExcavatorModel(new ExcavatorStatisticCreator(), quarry);

            WorldModel worldModel = new WorldModel(new WorldStatisticCreator());
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
        }
        private void InitWorld()
        {
            world = new WorldModel(new WorldStatisticCreator());

            AddExcToWorld(FirstExDataGridView);
            AddExcToWorld(SecondExDataGridView);
            AddExcToWorld(ThirdExDataGridView);
        }

        private void AddExcToWorld(DataGridView dataGridView)
        {
            for(int i = 0; i< dataGridView.Rows.Count; i++)
            {

            }
        }
    }
}
