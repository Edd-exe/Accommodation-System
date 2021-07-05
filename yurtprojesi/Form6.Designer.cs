namespace yurtprojesi
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.tbSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnByLastName = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnByDepartment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnByRoomNo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnByStudentID = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStudentDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.btnStudentPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsReturn = false;
            this.tbSearch.AcceptsTab = false;
            this.tbSearch.AnimationSpeed = 200;
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearch.BackgroundImage")));
            this.tbSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbSearch.BorderRadius = 1;
            this.tbSearch.BorderThickness = 1;
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.tbSearch.DefaultText = "";
            this.tbSearch.FillColor = System.Drawing.SystemColors.Control;
            this.tbSearch.HideSelection = true;
            this.tbSearch.IconLeft = null;
            this.tbSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.IconPadding = 12;
            this.tbSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("tbSearch.IconRight")));
            this.tbSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(43, 392);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSearch.Modified = false;
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.SystemColors.Control;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnIdleState = stateProperties4;
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search by Name...";
            this.tbSearch.ReadOnly = false;
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(362, 46);
            this.tbSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.TextMarginBottom = 0;
            this.tbSearch.TextMarginLeft = 5;
            this.tbSearch.TextMarginTop = 0;
            this.tbSearch.TextPlaceholder = "Search by Name...";
            this.tbSearch.UseSystemPasswordChar = false;
            this.tbSearch.WordWrap = true;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnByLastName
            // 
            this.btnByLastName.Active = false;
            this.btnByLastName.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnByLastName.BorderRadius = 0;
            this.btnByLastName.ButtonText = "by Last Name";
            this.btnByLastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnByLastName.DisabledColor = System.Drawing.Color.Gray;
            this.btnByLastName.Iconcolor = System.Drawing.Color.Transparent;
            this.btnByLastName.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnByLastName.Iconimage")));
            this.btnByLastName.Iconimage_right = null;
            this.btnByLastName.Iconimage_right_Selected = null;
            this.btnByLastName.Iconimage_Selected = null;
            this.btnByLastName.IconMarginLeft = 0;
            this.btnByLastName.IconMarginRight = 0;
            this.btnByLastName.IconRightVisible = true;
            this.btnByLastName.IconRightZoom = 0D;
            this.btnByLastName.IconVisible = true;
            this.btnByLastName.IconZoom = 90D;
            this.btnByLastName.IsTab = false;
            this.btnByLastName.Location = new System.Drawing.Point(237, 445);
            this.btnByLastName.Name = "btnByLastName";
            this.btnByLastName.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByLastName.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnByLastName.OnHoverTextColor = System.Drawing.Color.White;
            this.btnByLastName.selected = false;
            this.btnByLastName.Size = new System.Drawing.Size(168, 46);
            this.btnByLastName.TabIndex = 3;
            this.btnByLastName.Text = "by Last Name";
            this.btnByLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnByLastName.Textcolor = System.Drawing.Color.White;
            this.btnByLastName.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByLastName.Click += new System.EventHandler(this.btnByLastName_Click);
            // 
            // btnByDepartment
            // 
            this.btnByDepartment.Active = false;
            this.btnByDepartment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnByDepartment.BorderRadius = 0;
            this.btnByDepartment.ButtonText = "by Department";
            this.btnByDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnByDepartment.DisabledColor = System.Drawing.Color.Gray;
            this.btnByDepartment.Iconcolor = System.Drawing.Color.Transparent;
            this.btnByDepartment.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnByDepartment.Iconimage")));
            this.btnByDepartment.Iconimage_right = null;
            this.btnByDepartment.Iconimage_right_Selected = null;
            this.btnByDepartment.Iconimage_Selected = null;
            this.btnByDepartment.IconMarginLeft = 0;
            this.btnByDepartment.IconMarginRight = 0;
            this.btnByDepartment.IconRightVisible = true;
            this.btnByDepartment.IconRightZoom = 0D;
            this.btnByDepartment.IconVisible = true;
            this.btnByDepartment.IconZoom = 90D;
            this.btnByDepartment.IsTab = false;
            this.btnByDepartment.Location = new System.Drawing.Point(43, 445);
            this.btnByDepartment.Name = "btnByDepartment";
            this.btnByDepartment.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByDepartment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnByDepartment.OnHoverTextColor = System.Drawing.Color.White;
            this.btnByDepartment.selected = false;
            this.btnByDepartment.Size = new System.Drawing.Size(188, 46);
            this.btnByDepartment.TabIndex = 4;
            this.btnByDepartment.Text = "by Department";
            this.btnByDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnByDepartment.Textcolor = System.Drawing.Color.White;
            this.btnByDepartment.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByDepartment.Click += new System.EventHandler(this.btnByDepartment_Click);
            // 
            // btnByRoomNo
            // 
            this.btnByRoomNo.Active = false;
            this.btnByRoomNo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByRoomNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnByRoomNo.BorderRadius = 0;
            this.btnByRoomNo.ButtonText = "by Room No";
            this.btnByRoomNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnByRoomNo.DisabledColor = System.Drawing.Color.Gray;
            this.btnByRoomNo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnByRoomNo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnByRoomNo.Iconimage")));
            this.btnByRoomNo.Iconimage_right = null;
            this.btnByRoomNo.Iconimage_right_Selected = null;
            this.btnByRoomNo.Iconimage_Selected = null;
            this.btnByRoomNo.IconMarginLeft = 0;
            this.btnByRoomNo.IconMarginRight = 0;
            this.btnByRoomNo.IconRightVisible = true;
            this.btnByRoomNo.IconRightZoom = 0D;
            this.btnByRoomNo.IconVisible = true;
            this.btnByRoomNo.IconZoom = 90D;
            this.btnByRoomNo.IsTab = false;
            this.btnByRoomNo.Location = new System.Drawing.Point(411, 445);
            this.btnByRoomNo.Name = "btnByRoomNo";
            this.btnByRoomNo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByRoomNo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnByRoomNo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnByRoomNo.selected = false;
            this.btnByRoomNo.Size = new System.Drawing.Size(160, 46);
            this.btnByRoomNo.TabIndex = 5;
            this.btnByRoomNo.Text = "by Room No";
            this.btnByRoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnByRoomNo.Textcolor = System.Drawing.Color.White;
            this.btnByRoomNo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByRoomNo.Click += new System.EventHandler(this.btnByRoomNo_Click);
            // 
            // btnByStudentID
            // 
            this.btnByStudentID.Active = false;
            this.btnByStudentID.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByStudentID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnByStudentID.BorderRadius = 0;
            this.btnByStudentID.ButtonText = "by Student ID";
            this.btnByStudentID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnByStudentID.DisabledColor = System.Drawing.Color.Gray;
            this.btnByStudentID.Iconcolor = System.Drawing.Color.Transparent;
            this.btnByStudentID.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnByStudentID.Iconimage")));
            this.btnByStudentID.Iconimage_right = null;
            this.btnByStudentID.Iconimage_right_Selected = null;
            this.btnByStudentID.Iconimage_Selected = null;
            this.btnByStudentID.IconMarginLeft = 0;
            this.btnByStudentID.IconMarginRight = 0;
            this.btnByStudentID.IconRightVisible = true;
            this.btnByStudentID.IconRightZoom = 0D;
            this.btnByStudentID.IconVisible = true;
            this.btnByStudentID.IconZoom = 90D;
            this.btnByStudentID.IsTab = false;
            this.btnByStudentID.Location = new System.Drawing.Point(411, 393);
            this.btnByStudentID.Name = "btnByStudentID";
            this.btnByStudentID.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnByStudentID.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnByStudentID.OnHoverTextColor = System.Drawing.Color.White;
            this.btnByStudentID.selected = false;
            this.btnByStudentID.Size = new System.Drawing.Size(160, 46);
            this.btnByStudentID.TabIndex = 6;
            this.btnByStudentID.Text = "by Student ID";
            this.btnByStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnByStudentID.Textcolor = System.Drawing.Color.White;
            this.btnByStudentID.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByStudentID.Click += new System.EventHandler(this.btnByStudentID_Click);
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Active = false;
            this.btnStudentDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudentDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnStudentDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentDelete.BorderRadius = 0;
            this.btnStudentDelete.ButtonText = "   Delete";
            this.btnStudentDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudentDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudentDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudentDelete.Iconimage")));
            this.btnStudentDelete.Iconimage_right = null;
            this.btnStudentDelete.Iconimage_right_Selected = null;
            this.btnStudentDelete.Iconimage_Selected = null;
            this.btnStudentDelete.IconMarginLeft = 0;
            this.btnStudentDelete.IconMarginRight = 0;
            this.btnStudentDelete.IconRightVisible = true;
            this.btnStudentDelete.IconRightZoom = 0D;
            this.btnStudentDelete.IconVisible = true;
            this.btnStudentDelete.IconZoom = 50D;
            this.btnStudentDelete.IsTab = false;
            this.btnStudentDelete.Location = new System.Drawing.Point(577, 444);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnStudentDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStudentDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudentDelete.selected = false;
            this.btnStudentDelete.Size = new System.Drawing.Size(137, 46);
            this.btnStudentDelete.TabIndex = 8;
            this.btnStudentDelete.Text = "   Delete";
            this.btnStudentDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentDelete.Textcolor = System.Drawing.Color.White;
            this.btnStudentDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentDelete.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // dgStudent
            // 
            this.dgStudent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(32, 12);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.Size = new System.Drawing.Size(693, 374);
            this.dgStudent.TabIndex = 9;
            this.dgStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStudent_CellContentClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(420, 492);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(10, 13);
            this.lbl.TabIndex = 10;
            this.lbl.Text = " ";
            this.lbl.Visible = false;
            // 
            // btnStudentPrint
            // 
            this.btnStudentPrint.Active = false;
            this.btnStudentPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudentPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudentPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentPrint.BorderRadius = 0;
            this.btnStudentPrint.ButtonText = "   Print";
            this.btnStudentPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudentPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudentPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudentPrint.Iconimage")));
            this.btnStudentPrint.Iconimage_right = null;
            this.btnStudentPrint.Iconimage_right_Selected = null;
            this.btnStudentPrint.Iconimage_Selected = null;
            this.btnStudentPrint.IconMarginLeft = 0;
            this.btnStudentPrint.IconMarginRight = 0;
            this.btnStudentPrint.IconRightVisible = true;
            this.btnStudentPrint.IconRightZoom = 0D;
            this.btnStudentPrint.IconVisible = true;
            this.btnStudentPrint.IconZoom = 50D;
            this.btnStudentPrint.IsTab = false;
            this.btnStudentPrint.Location = new System.Drawing.Point(577, 392);
            this.btnStudentPrint.Name = "btnStudentPrint";
            this.btnStudentPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudentPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStudentPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudentPrint.selected = false;
            this.btnStudentPrint.Size = new System.Drawing.Size(137, 46);
            this.btnStudentPrint.TabIndex = 106;
            this.btnStudentPrint.Text = "   Print";
            this.btnStudentPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentPrint.Textcolor = System.Drawing.Color.White;
            this.btnStudentPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentPrint.Click += new System.EventHandler(this.btnStudentPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 504);
            this.Controls.Add(this.btnStudentPrint);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.btnStudentDelete);
            this.Controls.Add(this.btnByStudentID);
            this.Controls.Add(this.btnByRoomNo);
            this.Controls.Add(this.btnByDepartment);
            this.Controls.Add(this.btnByLastName);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbSearch;
        public Bunifu.Framework.UI.BunifuFlatButton btnByLastName;
        public Bunifu.Framework.UI.BunifuFlatButton btnByDepartment;
        public Bunifu.Framework.UI.BunifuFlatButton btnByRoomNo;
        public Bunifu.Framework.UI.BunifuFlatButton btnByStudentID;
        public Bunifu.Framework.UI.BunifuFlatButton btnStudentDelete;
        public System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.Label lbl;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudentPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}