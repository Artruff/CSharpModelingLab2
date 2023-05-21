
namespace CSharpModelingLab2
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestButton = new System.Windows.Forms.Button();
            this.FirstExDataGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeGoToExcavator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeGoToQuarry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyambdaLoading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyambdaShipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondExDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ThirdExDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogBox = new System.Windows.Forms.ListBox();
            this.TickButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CountTexBox = new System.Windows.Forms.TextBox();
            this.GlobalTimeLabel = new System.Windows.Forms.Label();
            this.GlobalTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirstExDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondExDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdExDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(911, 461);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // FirstExDataGridView
            // 
            this.FirstExDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstExDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Weight,
            this.TimeGoToExcavator,
            this.TimeGoToQuarry,
            this.lyambdaLoading,
            this.lyambdaShipment});
            this.FirstExDataGridView.Location = new System.Drawing.Point(12, 28);
            this.FirstExDataGridView.Name = "FirstExDataGridView";
            this.FirstExDataGridView.Size = new System.Drawing.Size(644, 133);
            this.FirstExDataGridView.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Вес";
            this.Weight.Name = "Weight";
            // 
            // TimeGoToExcavator
            // 
            this.TimeGoToExcavator.HeaderText = "Время до экс.";
            this.TimeGoToExcavator.Name = "TimeGoToExcavator";
            // 
            // TimeGoToQuarry
            // 
            this.TimeGoToQuarry.HeaderText = "Время до карьера";
            this.TimeGoToQuarry.Name = "TimeGoToQuarry";
            // 
            // lyambdaLoading
            // 
            this.lyambdaLoading.HeaderText = "Мат. ожид. загрузки";
            this.lyambdaLoading.Name = "lyambdaLoading";
            // 
            // lyambdaShipment
            // 
            this.lyambdaShipment.HeaderText = "Мат. Ожид. разгрузки";
            this.lyambdaShipment.Name = "lyambdaShipment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первый экскаватор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Второй экскаватор";
            // 
            // SecondExDataGridView
            // 
            this.SecondExDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondExDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.SecondExDataGridView.Location = new System.Drawing.Point(12, 190);
            this.SecondExDataGridView.Name = "SecondExDataGridView";
            this.SecondExDataGridView.Size = new System.Drawing.Size(644, 133);
            this.SecondExDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Вес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Время до экс.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Время до карьера";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Мат. ожид. загрузки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Мат. Ожид. разгрузки";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Третий экскаватор";
            // 
            // ThirdExDataGridView
            // 
            this.ThirdExDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThirdExDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.ThirdExDataGridView.Location = new System.Drawing.Point(12, 351);
            this.ThirdExDataGridView.Name = "ThirdExDataGridView";
            this.ThirdExDataGridView.Size = new System.Drawing.Size(644, 133);
            this.ThirdExDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Вес";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Время до экс.";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Время до карьера";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Мат. ожид. загрузки";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Мат. Ожид. разгрузки";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // LogBox
            // 
            this.LogBox.FormattingEnabled = true;
            this.LogBox.Location = new System.Drawing.Point(676, 28);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(310, 290);
            this.LogBox.TabIndex = 7;
            // 
            // TickButton
            // 
            this.TickButton.Location = new System.Drawing.Point(678, 385);
            this.TickButton.Name = "TickButton";
            this.TickButton.Size = new System.Drawing.Size(75, 23);
            this.TickButton.TabIndex = 8;
            this.TickButton.Text = "Tick";
            this.TickButton.UseVisualStyleBackColor = true;
            this.TickButton.Click += new System.EventHandler(this.TickButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CountTexBox
            // 
            this.CountTexBox.Location = new System.Drawing.Point(869, 385);
            this.CountTexBox.Name = "CountTexBox";
            this.CountTexBox.Size = new System.Drawing.Size(100, 20);
            this.CountTexBox.TabIndex = 10;
            this.CountTexBox.Text = "10";
            // 
            // GlobalTimeLabel
            // 
            this.GlobalTimeLabel.AutoSize = true;
            this.GlobalTimeLabel.Location = new System.Drawing.Point(676, 351);
            this.GlobalTimeLabel.Name = "GlobalTimeLabel";
            this.GlobalTimeLabel.Size = new System.Drawing.Size(65, 13);
            this.GlobalTimeLabel.TabIndex = 11;
            this.GlobalTimeLabel.Text = "Global  time:";
            // 
            // GlobalTime
            // 
            this.GlobalTime.AutoSize = true;
            this.GlobalTime.Location = new System.Drawing.Point(748, 351);
            this.GlobalTime.Name = "GlobalTime";
            this.GlobalTime.Size = new System.Drawing.Size(13, 13);
            this.GlobalTime.TabIndex = 12;
            this.GlobalTime.Text = "0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 491);
            this.Controls.Add(this.GlobalTime);
            this.Controls.Add(this.GlobalTimeLabel);
            this.Controls.Add(this.CountTexBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TickButton);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThirdExDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondExDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstExDataGridView);
            this.Controls.Add(this.TestButton);
            this.Name = "MainWindow";
            this.Text = "Quarry";
            ((System.ComponentModel.ISupportInitialize)(this.FirstExDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondExDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdExDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.DataGridView FirstExDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeGoToExcavator;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeGoToQuarry;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyambdaLoading;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyambdaShipment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SecondExDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ThirdExDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ListBox LogBox;
        private System.Windows.Forms.Button TickButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CountTexBox;
        private System.Windows.Forms.Label GlobalTimeLabel;
        private System.Windows.Forms.Label GlobalTime;
    }
}

