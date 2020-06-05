namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.Separator0 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectLabel = new System.Windows.Forms.ToolStripTextBox();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Draw = new System.Windows.Forms.ToolStripTextBox();
            this.DrawLineSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawElispeSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.fillColorSelectButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(693, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 401);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(693, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.speedMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator0,
            this.SelectLabel,
            this.pickUpSpeedButton,
            this.Separator1,
            this.Draw,
            this.DrawLineSpeedButton,
            this.drawElispeSpeedButton,
            this.drawRectangleSpeedButton,
            this.Separator2,
            this.fillColorSelectButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.speedMenu.Size = new System.Drawing.Size(44, 377);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            this.speedMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.speedMenu_ItemClicked);
            // 
            // Separator0
            // 
            this.Separator0.Name = "Separator0";
            this.Separator0.Size = new System.Drawing.Size(41, 6);
            // 
            // SelectLabel
            // 
            this.SelectLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(39, 22);
            this.SelectLabel.Text = "Select";
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(41, 20);
            this.pickUpSpeedButton.Text = "fillColorSelectButton";
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(41, 6);
            // 
            // Draw
            // 
            this.Draw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Draw.Name = "Draw";
            this.Draw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Draw.Size = new System.Drawing.Size(39, 22);
            this.Draw.Text = "Draw";
            // 
            // DrawLineSpeedButton
            // 
            this.DrawLineSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawLineSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawLineSpeedButton.Image")));
            this.DrawLineSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawLineSpeedButton.Name = "DrawLineSpeedButton";
            this.DrawLineSpeedButton.Size = new System.Drawing.Size(41, 20);
            this.DrawLineSpeedButton.Text = "DrawLineSpeedButton";
            this.DrawLineSpeedButton.ToolTipText = "Draw Line";
            this.DrawLineSpeedButton.Click += new System.EventHandler(this.DrawLineSpeedButtonClick);
            // 
            // drawElispeSpeedButton
            // 
            this.drawElispeSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawElispeSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawElispeSpeedButton.Image")));
            this.drawElispeSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawElispeSpeedButton.Name = "drawElispeSpeedButton";
            this.drawElispeSpeedButton.Size = new System.Drawing.Size(41, 20);
            this.drawElispeSpeedButton.Text = "DrawElispeButton";
            this.drawElispeSpeedButton.ToolTipText = "Draw Elipse";
            this.drawElispeSpeedButton.Click += new System.EventHandler(this.DrawElispeSpeedButtonClick);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(41, 20);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.ToolTipText = "Draw Rectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(41, 6);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(44, 24);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(649, 377);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // fillColorSelectButton
            // 
            this.fillColorSelectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillColorSelectButton.Image = ((System.Drawing.Image)(resources.GetObject("fillColorSelectButton.Image")));
            this.fillColorSelectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorSelectButton.Name = "fillColorSelectButton";
            this.fillColorSelectButton.Size = new System.Drawing.Size(41, 20);
            this.fillColorSelectButton.Text = "fillColorSelectButton";
            this.fillColorSelectButton.Click += new System.EventHandler(this.SelectColorButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripTextBox SelectLabel;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripTextBox Draw;
        private System.Windows.Forms.ToolStripButton DrawLineSpeedButton;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripSeparator Separator0;
        private System.Windows.Forms.ToolStripButton drawElispeSpeedButton;
        private System.Windows.Forms.ToolStripButton fillColorSelectButton;
    }
}
