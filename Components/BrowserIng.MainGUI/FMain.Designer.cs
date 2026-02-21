namespace BrowserIng.MainGUI
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            toolStripContainer1 = new ToolStripContainer();
            tabControl1 = new TabControl();
            toolStrip2 = new ToolStrip();
            imageList1 = new ImageList(components);
            toolStripButton8 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            _urlBarTextBox = new ToolStripSpringTextBox();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton10 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            imageList2 = new ImageList(components);
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tabControl1);
            toolStripContainer1.ContentPanel.Size = new Size(1234, 759);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1234, 784);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.BackColor = Color.Transparent;
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip2);
            // 
            // tabControl1
            // 
            tabControl1.AllowDrop = true;
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1234, 759);
            tabControl1.TabIndex = 2;
            tabControl1.Selected += tabControl1_Selected;
            tabControl1.DragOver += tabControl1_DragOver;
            tabControl1.MouseDown += tabControl1_MouseDown;
            tabControl1.MouseMove += tabControl1_MouseMove_1;
            // 
            // toolStrip2
            // 
            toolStrip2.BackColor = Color.Transparent;
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.ImageList = imageList1;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton8, toolStripButton7, toolStripButton6, toolStripButton4, toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton9, toolStripSeparator2, _urlBarTextBox, toolStripSeparator3, toolStripButton10, toolStripButton5 });
            toolStrip2.Location = new Point(3, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1018, 25);
            toolStrip2.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add column.ico");
            imageList1.Images.SetKeyName(1, "add row.ico");
            imageList1.Images.SetKeyName(2, "add user.ico");
            imageList1.Images.SetKeyName(3, "alarm.ico");
            imageList1.Images.SetKeyName(4, "align bottom.ico");
            imageList1.Images.SetKeyName(5, "align center.ico");
            imageList1.Images.SetKeyName(6, "align center1.ico");
            imageList1.Images.SetKeyName(7, "align columns.ico");
            imageList1.Images.SetKeyName(8, "align left.ico");
            imageList1.Images.SetKeyName(9, "align right.ico");
            imageList1.Images.SetKeyName(10, "align top.ico");
            imageList1.Images.SetKeyName(11, "all borders.ico");
            imageList1.Images.SetKeyName(12, "attention.ico");
            imageList1.Images.SetKeyName(13, "back 1.ico");
            imageList1.Images.SetKeyName(14, "back.ico");
            imageList1.Images.SetKeyName(15, "balloon.ico");
            imageList1.Images.SetKeyName(16, "bold.ico");
            imageList1.Images.SetKeyName(17, "book 1.ico");
            imageList1.Images.SetKeyName(18, "book bookmark 1.ico");
            imageList1.Images.SetKeyName(19, "book bookmark.ico");
            imageList1.Images.SetKeyName(20, "book.ico");
            imageList1.Images.SetKeyName(21, "bottom border.ico");
            imageList1.Images.SetKeyName(22, "bulb.ico");
            imageList1.Images.SetKeyName(23, "calculator.ico");
            imageList1.Images.SetKeyName(24, "calendar 2.ico");
            imageList1.Images.SetKeyName(25, "calendar.ico");
            imageList1.Images.SetKeyName(26, "cancel.ico");
            imageList1.Images.SetKeyName(27, "case.ico");
            imageList1.Images.SetKeyName(28, "cd disk.ico");
            imageList1.Images.SetKeyName(29, "certificate.ico");
            imageList1.Images.SetKeyName(30, "choose language.ico");
            imageList1.Images.SetKeyName(31, "clock.ico");
            imageList1.Images.SetKeyName(32, "close file.ico");
            imageList1.Images.SetKeyName(33, "copy.ico");
            imageList1.Images.SetKeyName(34, "cut.ico");
            imageList1.Images.SetKeyName(35, "database  add.ico");
            imageList1.Images.SetKeyName(36, "database delete.ico");
            imageList1.Images.SetKeyName(37, "database.ico");
            imageList1.Images.SetKeyName(38, "database-check.ico");
            imageList1.Images.SetKeyName(39, "decrease indent.ico");
            imageList1.Images.SetKeyName(40, "delete 1.ico");
            imageList1.Images.SetKeyName(41, "delete column.ico");
            imageList1.Images.SetKeyName(42, "delete database.ico");
            imageList1.Images.SetKeyName(43, "delete row.ico");
            imageList1.Images.SetKeyName(44, "delete.ico");
            imageList1.Images.SetKeyName(45, "diagram.ico");
            imageList1.Images.SetKeyName(46, "display.ico");
            imageList1.Images.SetKeyName(47, "down.ico");
            imageList1.Images.SetKeyName(48, "envelope cross.ico");
            imageList1.Images.SetKeyName(49, "envelope in.ico");
            imageList1.Images.SetKeyName(50, "envelope out.ico");
            imageList1.Images.SetKeyName(51, "envelope pencil.ico");
            imageList1.Images.SetKeyName(52, "envelope.ico");
            imageList1.Images.SetKeyName(53, "envelope-check.ico");
            imageList1.Images.SetKeyName(54, "exit.ico");
            imageList1.Images.SetKeyName(55, "favorites.ico");
            imageList1.Images.SetKeyName(56, "fax.ico");
            imageList1.Images.SetKeyName(57, "find next.ico");
            imageList1.Images.SetKeyName(58, "find.ico");
            imageList1.Images.SetKeyName(59, "flag green.ico");
            imageList1.Images.SetKeyName(60, "flag red.ico");
            imageList1.Images.SetKeyName(61, "flag yellow.ico");
            imageList1.Images.SetKeyName(62, "font background.ico");
            imageList1.Images.SetKeyName(63, "font сolor.ico");
            imageList1.Images.SetKeyName(64, "forward.ico");
            imageList1.Images.SetKeyName(65, "globe.ico");
            imageList1.Images.SetKeyName(66, "grow font.ico");
            imageList1.Images.SetKeyName(67, "hard disk.ico");
            imageList1.Images.SetKeyName(68, "history.ico");
            imageList1.Images.SetKeyName(69, "home.ico");
            imageList1.Images.SetKeyName(70, "import camera.ico");
            imageList1.Images.SetKeyName(71, "import scanner.ico");
            imageList1.Images.SetKeyName(72, "import.ico");
            imageList1.Images.SetKeyName(73, "increase indent.ico");
            imageList1.Images.SetKeyName(74, "increase.ico");
            imageList1.Images.SetKeyName(75, "insert table.ico");
            imageList1.Images.SetKeyName(76, "insert.ico");
            imageList1.Images.SetKeyName(77, "italic.ico");
            imageList1.Images.SetKeyName(78, "key.ico");
            imageList1.Images.SetKeyName(79, "left border.ico");
            imageList1.Images.SetKeyName(80, "left.ico");
            imageList1.Images.SetKeyName(81, "lock.ico");
            imageList1.Images.SetKeyName(82, "magnifier.ico");
            imageList1.Images.SetKeyName(83, "marked list points.ico");
            imageList1.Images.SetKeyName(84, "master.ico");
            imageList1.Images.SetKeyName(85, "megaphone.ico");
            imageList1.Images.SetKeyName(86, "merge cells.ico");
            imageList1.Images.SetKeyName(87, "minus.ico");
            imageList1.Images.SetKeyName(88, "mouse cursor.ico");
            imageList1.Images.SetKeyName(89, "mouse.ico");
            imageList1.Images.SetKeyName(90, "new.ico");
            imageList1.Images.SetKeyName(91, "no borders.ico");
            imageList1.Images.SetKeyName(92, "note.ico");
            imageList1.Images.SetKeyName(93, "numbered list.ico");
            imageList1.Images.SetKeyName(94, "open database.ico");
            imageList1.Images.SetKeyName(95, "open envelope.ico");
            imageList1.Images.SetKeyName(96, "open network file.ico");
            imageList1.Images.SetKeyName(97, "open.ico");
            imageList1.Images.SetKeyName(98, "options.ico");
            imageList1.Images.SetKeyName(99, "page settings.ico");
            imageList1.Images.SetKeyName(100, "paper clip 1.ico");
            imageList1.Images.SetKeyName(101, "paper clip 2.ico");
            imageList1.Images.SetKeyName(102, "paper clip.ico");
            imageList1.Images.SetKeyName(103, "pause.ico");
            imageList1.Images.SetKeyName(104, "pencil ruler.ico");
            imageList1.Images.SetKeyName(105, "phone.ico");
            imageList1.Images.SetKeyName(106, "picture.ico");
            imageList1.Images.SetKeyName(107, "play.ico");
            imageList1.Images.SetKeyName(108, "plus.ico");
            imageList1.Images.SetKeyName(109, "preview.ico");
            imageList1.Images.SetKeyName(110, "printer.ico");
            imageList1.Images.SetKeyName(111, "property.ico");
            imageList1.Images.SetKeyName(112, "record.ico");
            imageList1.Images.SetKeyName(113, "recycle bin sign.ico");
            imageList1.Images.SetKeyName(114, "recycle bin.ico");
            imageList1.Images.SetKeyName(115, "reduce.ico");
            imageList1.Images.SetKeyName(116, "remove user.ico");
            imageList1.Images.SetKeyName(117, "replace.ico");
            imageList1.Images.SetKeyName(118, "rewind back.ico");
            imageList1.Images.SetKeyName(119, "rewind forward.ico");
            imageList1.Images.SetKeyName(120, "right border.ico");
            imageList1.Images.SetKeyName(121, "right.ico");
            imageList1.Images.SetKeyName(122, "save as.ico");
            imageList1.Images.SetKeyName(123, "save.ico");
            imageList1.Images.SetKeyName(124, "search 2.ico");
            imageList1.Images.SetKeyName(125, "search database.ico");
            imageList1.Images.SetKeyName(126, "search.ico");
            imageList1.Images.SetKeyName(127, "shrink font.ico");
            imageList1.Images.SetKeyName(128, "skip back.ico");
            imageList1.Images.SetKeyName(129, "skip forward.ico");
            imageList1.Images.SetKeyName(130, "spell.ico");
            imageList1.Images.SetKeyName(131, "split cells.ico");
            imageList1.Images.SetKeyName(132, "stop 2.ico");
            imageList1.Images.SetKeyName(133, "stop.ico");
            imageList1.Images.SetKeyName(134, "strikeout.ico");
            imageList1.Images.SetKeyName(135, "subscript.ico");
            imageList1.Images.SetKeyName(136, "superscript.ico");
            imageList1.Images.SetKeyName(137, "table.ico");
            imageList1.Images.SetKeyName(138, "top border.ico");
            imageList1.Images.SetKeyName(139, "two displays.ico");
            imageList1.Images.SetKeyName(140, "two pictures.ico");
            imageList1.Images.SetKeyName(141, "underline.ico");
            imageList1.Images.SetKeyName(142, "unmerge cells.ico");
            imageList1.Images.SetKeyName(143, "up.ico");
            imageList1.Images.SetKeyName(144, "update.ico");
            imageList1.Images.SetKeyName(145, "user.ico");
            imageList1.Images.SetKeyName(146, "еxport.ico");
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(37, 22);
            toolStripButton8.Text = "NEW";
            toolStripButton8.Click += toolStripButtonNEW_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(44, 22);
            toolStripButton7.Text = "Home";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(28, 22);
            toolStripButton6.Text = "GO";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(55, 22);
            toolStripButton1.Text = "< BACK ";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(78, 22);
            toolStripButton2.Text = "FORWARD >";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(38, 22);
            toolStripButton3.Text = "STOP";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton9
            // 
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton9.Image = (Image)resources.GetObject("toolStripButton9.Image");
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(46, 22);
            toolStripButton9.Text = "CLOSE";
            toolStripButton9.Click += toolStripButton9_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(58, 22);
            toolStripButton4.Text = "REFRESH";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // _urlBarTextBox
            // 
            _urlBarTextBox.AutoSize = false;
            _urlBarTextBox.Dock = DockStyle.Fill;
            _urlBarTextBox.Name = "_urlBarTextBox";
            _urlBarTextBox.Overflow = ToolStripItemOverflow.Never;
            _urlBarTextBox.Size = new Size(466, 23);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripButton10
            // 
            toolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton10.Image = (Image)resources.GetObject("toolStripButton10.Image");
            toolStripButton10.ImageTransparentColor = Color.Magenta;
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Size = new Size(67, 22);
            toolStripButton10.Text = "DEVTOOLS";
            toolStripButton10.Click += toolStripButton10_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(44, 22);
            toolStripButton5.Text = "SETUP";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "add column.ico");
            imageList2.Images.SetKeyName(1, "add row.ico");
            imageList2.Images.SetKeyName(2, "add user.ico");
            imageList2.Images.SetKeyName(3, "alarm.ico");
            imageList2.Images.SetKeyName(4, "align bottom.ico");
            imageList2.Images.SetKeyName(5, "align center.ico");
            imageList2.Images.SetKeyName(6, "align center1.ico");
            imageList2.Images.SetKeyName(7, "align columns.ico");
            imageList2.Images.SetKeyName(8, "align left.ico");
            imageList2.Images.SetKeyName(9, "align right.ico");
            imageList2.Images.SetKeyName(10, "align top.ico");
            imageList2.Images.SetKeyName(11, "all borders.ico");
            imageList2.Images.SetKeyName(12, "attention.ico");
            imageList2.Images.SetKeyName(13, "back 1.ico");
            imageList2.Images.SetKeyName(14, "back.ico");
            imageList2.Images.SetKeyName(15, "balloon.ico");
            imageList2.Images.SetKeyName(16, "bold.ico");
            imageList2.Images.SetKeyName(17, "book 1.ico");
            imageList2.Images.SetKeyName(18, "book bookmark 1.ico");
            imageList2.Images.SetKeyName(19, "book bookmark.ico");
            imageList2.Images.SetKeyName(20, "book.ico");
            imageList2.Images.SetKeyName(21, "bottom border.ico");
            imageList2.Images.SetKeyName(22, "bulb.ico");
            imageList2.Images.SetKeyName(23, "calculator.ico");
            imageList2.Images.SetKeyName(24, "calendar 2.ico");
            imageList2.Images.SetKeyName(25, "calendar.ico");
            imageList2.Images.SetKeyName(26, "cancel.ico");
            imageList2.Images.SetKeyName(27, "case.ico");
            imageList2.Images.SetKeyName(28, "cd disk.ico");
            imageList2.Images.SetKeyName(29, "certificate.ico");
            imageList2.Images.SetKeyName(30, "choose language.ico");
            imageList2.Images.SetKeyName(31, "clock.ico");
            imageList2.Images.SetKeyName(32, "close file.ico");
            imageList2.Images.SetKeyName(33, "copy.ico");
            imageList2.Images.SetKeyName(34, "cut.ico");
            imageList2.Images.SetKeyName(35, "database  add.ico");
            imageList2.Images.SetKeyName(36, "database delete.ico");
            imageList2.Images.SetKeyName(37, "database.ico");
            imageList2.Images.SetKeyName(38, "database-check.ico");
            imageList2.Images.SetKeyName(39, "decrease indent.ico");
            imageList2.Images.SetKeyName(40, "delete 1.ico");
            imageList2.Images.SetKeyName(41, "delete column.ico");
            imageList2.Images.SetKeyName(42, "delete database.ico");
            imageList2.Images.SetKeyName(43, "delete row.ico");
            imageList2.Images.SetKeyName(44, "delete.ico");
            imageList2.Images.SetKeyName(45, "diagram.ico");
            imageList2.Images.SetKeyName(46, "display.ico");
            imageList2.Images.SetKeyName(47, "down.ico");
            imageList2.Images.SetKeyName(48, "envelope cross.ico");
            imageList2.Images.SetKeyName(49, "envelope in.ico");
            imageList2.Images.SetKeyName(50, "envelope out.ico");
            imageList2.Images.SetKeyName(51, "envelope pencil.ico");
            imageList2.Images.SetKeyName(52, "envelope.ico");
            imageList2.Images.SetKeyName(53, "envelope-check.ico");
            imageList2.Images.SetKeyName(54, "exit.ico");
            imageList2.Images.SetKeyName(55, "favorites.ico");
            imageList2.Images.SetKeyName(56, "fax.ico");
            imageList2.Images.SetKeyName(57, "find next.ico");
            imageList2.Images.SetKeyName(58, "find.ico");
            imageList2.Images.SetKeyName(59, "flag green.ico");
            imageList2.Images.SetKeyName(60, "flag red.ico");
            imageList2.Images.SetKeyName(61, "flag yellow.ico");
            imageList2.Images.SetKeyName(62, "font background.ico");
            imageList2.Images.SetKeyName(63, "font сolor.ico");
            imageList2.Images.SetKeyName(64, "forward.ico");
            imageList2.Images.SetKeyName(65, "globe.ico");
            imageList2.Images.SetKeyName(66, "grow font.ico");
            imageList2.Images.SetKeyName(67, "hard disk.ico");
            imageList2.Images.SetKeyName(68, "history.ico");
            imageList2.Images.SetKeyName(69, "home.ico");
            imageList2.Images.SetKeyName(70, "import camera.ico");
            imageList2.Images.SetKeyName(71, "import scanner.ico");
            imageList2.Images.SetKeyName(72, "import.ico");
            imageList2.Images.SetKeyName(73, "increase indent.ico");
            imageList2.Images.SetKeyName(74, "increase.ico");
            imageList2.Images.SetKeyName(75, "insert table.ico");
            imageList2.Images.SetKeyName(76, "insert.ico");
            imageList2.Images.SetKeyName(77, "italic.ico");
            imageList2.Images.SetKeyName(78, "key.ico");
            imageList2.Images.SetKeyName(79, "left border.ico");
            imageList2.Images.SetKeyName(80, "left.ico");
            imageList2.Images.SetKeyName(81, "lock.ico");
            imageList2.Images.SetKeyName(82, "magnifier.ico");
            imageList2.Images.SetKeyName(83, "marked list points.ico");
            imageList2.Images.SetKeyName(84, "master.ico");
            imageList2.Images.SetKeyName(85, "megaphone.ico");
            imageList2.Images.SetKeyName(86, "merge cells.ico");
            imageList2.Images.SetKeyName(87, "minus.ico");
            imageList2.Images.SetKeyName(88, "mouse cursor.ico");
            imageList2.Images.SetKeyName(89, "mouse.ico");
            imageList2.Images.SetKeyName(90, "new.ico");
            imageList2.Images.SetKeyName(91, "no borders.ico");
            imageList2.Images.SetKeyName(92, "note.ico");
            imageList2.Images.SetKeyName(93, "numbered list.ico");
            imageList2.Images.SetKeyName(94, "open database.ico");
            imageList2.Images.SetKeyName(95, "open envelope.ico");
            imageList2.Images.SetKeyName(96, "open network file.ico");
            imageList2.Images.SetKeyName(97, "open.ico");
            imageList2.Images.SetKeyName(98, "options.ico");
            imageList2.Images.SetKeyName(99, "page settings.ico");
            imageList2.Images.SetKeyName(100, "paper clip 1.ico");
            imageList2.Images.SetKeyName(101, "paper clip 2.ico");
            imageList2.Images.SetKeyName(102, "paper clip.ico");
            imageList2.Images.SetKeyName(103, "pause.ico");
            imageList2.Images.SetKeyName(104, "pencil ruler.ico");
            imageList2.Images.SetKeyName(105, "phone.ico");
            imageList2.Images.SetKeyName(106, "picture.ico");
            imageList2.Images.SetKeyName(107, "play.ico");
            imageList2.Images.SetKeyName(108, "plus.ico");
            imageList2.Images.SetKeyName(109, "preview.ico");
            imageList2.Images.SetKeyName(110, "printer.ico");
            imageList2.Images.SetKeyName(111, "property.ico");
            imageList2.Images.SetKeyName(112, "record.ico");
            imageList2.Images.SetKeyName(113, "recycle bin sign.ico");
            imageList2.Images.SetKeyName(114, "recycle bin.ico");
            imageList2.Images.SetKeyName(115, "reduce.ico");
            imageList2.Images.SetKeyName(116, "remove user.ico");
            imageList2.Images.SetKeyName(117, "replace.ico");
            imageList2.Images.SetKeyName(118, "rewind back.ico");
            imageList2.Images.SetKeyName(119, "rewind forward.ico");
            imageList2.Images.SetKeyName(120, "right border.ico");
            imageList2.Images.SetKeyName(121, "right.ico");
            imageList2.Images.SetKeyName(122, "save as.ico");
            imageList2.Images.SetKeyName(123, "save.ico");
            imageList2.Images.SetKeyName(124, "search 2.ico");
            imageList2.Images.SetKeyName(125, "search database.ico");
            imageList2.Images.SetKeyName(126, "search.ico");
            imageList2.Images.SetKeyName(127, "shrink font.ico");
            imageList2.Images.SetKeyName(128, "skip back.ico");
            imageList2.Images.SetKeyName(129, "skip forward.ico");
            imageList2.Images.SetKeyName(130, "spell.ico");
            imageList2.Images.SetKeyName(131, "split cells.ico");
            imageList2.Images.SetKeyName(132, "stop 2.ico");
            imageList2.Images.SetKeyName(133, "stop.ico");
            imageList2.Images.SetKeyName(134, "strikeout.ico");
            imageList2.Images.SetKeyName(135, "subscript.ico");
            imageList2.Images.SetKeyName(136, "superscript.ico");
            imageList2.Images.SetKeyName(137, "table.ico");
            imageList2.Images.SetKeyName(138, "top border.ico");
            imageList2.Images.SetKeyName(139, "two displays.ico");
            imageList2.Images.SetKeyName(140, "two pictures.ico");
            imageList2.Images.SetKeyName(141, "underline.ico");
            imageList2.Images.SetKeyName(142, "unmerge cells.ico");
            imageList2.Images.SetKeyName(143, "up.ico");
            imageList2.Images.SetKeyName(144, "update.ico");
            imageList2.Images.SetKeyName(145, "user.ico");
            imageList2.Images.SetKeyName(146, "еxport.ico");
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 784);
            Controls.Add(toolStripContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FMain";
            Text = "BrowserIng";
            FormClosing += FMain_FormClosing;
            Load += FMain_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ImageList imageList1;
        private ImageList imageList2;
        private TabControl tabControl1;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton10;
        internal ToolStripSpringTextBox _urlBarTextBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
    }
}
