namespace CarSelling2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tabpage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.addOffers1 = new CarSelling2.UserInterface.AddOffers();
            this.offers1 = new CarSelling2.UserInterface.Offers();
            this.offersManagment1 = new CarSelling2.UserInterface.OffersManagment();
            this.sellingTime1 = new CarSelling2.UserInterface.SellingTime();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Tabpage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Tabpage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(603, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addOffers1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AddOffers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Tabpage2
            // 
            this.Tabpage2.Controls.Add(this.offers1);
            this.Tabpage2.Location = new System.Drawing.Point(4, 22);
            this.Tabpage2.Name = "Tabpage2";
            this.Tabpage2.Padding = new System.Windows.Forms.Padding(3);
            this.Tabpage2.Size = new System.Drawing.Size(595, 408);
            this.Tabpage2.TabIndex = 1;
            this.Tabpage2.Text = "ShowOffers";
            this.Tabpage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.offersManagment1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(595, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "OffersManager";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.sellingTime1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(595, 408);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Selling Information";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // addOffers1
            // 
            this.addOffers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOffers1.Location = new System.Drawing.Point(3, 3);
            this.addOffers1.Name = "addOffers1";
            this.addOffers1.Size = new System.Drawing.Size(589, 402);
            this.addOffers1.TabIndex = 0;
            // 
            // offers1
            // 
            this.offers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offers1.Location = new System.Drawing.Point(3, 3);
            this.offers1.Name = "offers1";
            this.offers1.Size = new System.Drawing.Size(589, 402);
            this.offers1.TabIndex = 0;
            // 
            // offersManagment1
            // 
            this.offersManagment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offersManagment1.Location = new System.Drawing.Point(3, 3);
            this.offersManagment1.Name = "offersManagment1";
            this.offersManagment1.Size = new System.Drawing.Size(589, 402);
            this.offersManagment1.TabIndex = 0;
            // 
            // sellingTime1
            // 
            this.sellingTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellingTime1.Location = new System.Drawing.Point(3, 3);
            this.sellingTime1.Name = "sellingTime1";
            this.sellingTime1.Size = new System.Drawing.Size(589, 402);
            this.sellingTime1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Tabpage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UserInterface.AddOffers addOffers1;
        private System.Windows.Forms.TabPage Tabpage2;
        private UserInterface.Offers offers1;
        private System.Windows.Forms.TabPage tabPage3;
        private UserInterface.OffersManagment offersManagment1;
        private System.Windows.Forms.TabPage tabPage4;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private UserInterface.SellingTime sellingTime1;
    }
}

