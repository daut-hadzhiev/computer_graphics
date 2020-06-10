using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Draw
{
    /// <summary>
    /// Върху главната форма е поставен потребителски контрол,
    /// в който се осъществява визуализацията
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
        /// </summary>
        private DialogProcessor dialogProcessor = new DialogProcessor();

        private Color lastSelectedFillColor = Color.White;
        private Color lastSelectedBorderColor = Color.Black;


        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();


            this.fillColorSelectButton.BackColor = this.lastSelectedFillColor;
            this.borderColorSelectButton.BackColor = this.lastSelectedBorderColor;
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }


        /// <summary>
        /// Изход от програмата. Затваря главната форма, а с това и програмата.
        /// </summary>
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }

        /// <summary>
        /// Бутон, който поставя на произволно място правоъгълник със зададените размери.
        /// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
        /// </summary>
        void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRectangle(this.lastSelectedFillColor, this.lastSelectedBorderColor);

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

            viewPort.Invalidate();
        }

        /// <summary>
		/// Бутон, който поставя на произволно място линия със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
        private void DrawLineSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomLine(this.lastSelectedBorderColor);

            statusBar.Items[0].Text = "Последно действие: Рисуване на линия";

            viewPort.Invalidate();
        }

        private void DrawElipseSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomElipse(this.lastSelectedFillColor, this.lastSelectedBorderColor);

            statusBar.Items[0].Text = "Последно действие: Рисуване на Елипса";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        /// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        /// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        /// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        /// </summary>
        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pickUpSpeedButton.Checked)
            {

                dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);
                if (dialogProcessor.Selection != null)
                {
                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }
        }

        /// <summary>
        /// Прихващане на преместването на мишката.
        /// Ако сме в режм на "влачене", то избрания елемент се транслира.
        /// </summary>
        void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {
                if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
                dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Прихващане на отпускането на бутона на мишката.
        /// Излизаме от режим "влачене".
        /// </summary>
        void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dialogProcessor.IsDragging = false;
        }

        private void SelectColorButtonClick(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            var dialogResult = dlg.ShowDialog();

            statusBar.Items[0].Text = "Последно действие: Избор на цвят";

            if (dialogResult == DialogResult.OK)
            {
                lastSelectedFillColor = dlg.Color;
                this.fillColorSelectButton.BackColor = lastSelectedFillColor;
            }

            if (this.dialogProcessor.Selection != null)
            {
                this.dialogProcessor.Selection.FillColor = lastSelectedFillColor;
                this.viewPort.Invalidate();
            }
        }

        private void borderColorSelectButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            var dialogResult = dlg.ShowDialog();

            statusBar.Items[0].Text = "Последно действие: Избор на цвят на рамка";

            if (dialogResult == DialogResult.OK)
            {
                lastSelectedBorderColor = dlg.Color;
                this.borderColorSelectButton.BackColor = lastSelectedBorderColor;
            }

            if (this.dialogProcessor.Selection != null)
            {
                this.dialogProcessor.Selection.BorderColor = lastSelectedBorderColor;
                this.viewPort.Invalidate();
            }
        }

        private void colorAllRectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dialogProcessor.ShapeList.Count; i++)
            {
                var currShape = dialogProcessor.ShapeList[i];
                if (currShape is RectangleShape)
                {
                    currShape.FillColor = lastSelectedFillColor;
                    currShape.BorderColor = lastSelectedBorderColor;
                }
            }
            this.viewPort.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = new List<string>();

            foreach (var shape in this.dialogProcessor.ShapeList)
            {
                string shapeType = "";

                if (shape is RectangleShape)
                {
                    shapeType = "rectangle";
                }
                else if (shape is LineShape)
                {
                    shapeType = "line";
                }
                else if (shape is ElipseShape)
                {
                    shapeType = "elipse";
                }

                list.Add($"{shapeType}|{JsonConvert.SerializeObject(shape)}");
            }

            File.WriteAllText("save.json", JsonConvert.SerializeObject(list));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var shapeListJson = File.ReadAllText("save.json");
            var shapeListObjects = JsonConvert.DeserializeObject<List<string>>(shapeListJson);

            var shapeList = new List<Shape>();

            foreach (var shapeObject in shapeListObjects)
            {
                var parts = shapeObject.Split('|');

                var shapeType = parts[0];
                var shapeProperties = parts[1];

                Shape currentShape = JsonConvert.DeserializeObject<Shape>(shapeProperties);
                Shape typizedShape = null;

                if (shapeType == "rectangle")
                {                    
                    typizedShape = new RectangleShape(currentShape.Rectangle);
                }
                else if (shapeType == "line")
                {
                    typizedShape = new LineShape(currentShape.Rectangle);
                }
                else if (shapeType == "elipse")
                {
                    typizedShape = new ElipseShape(currentShape.Rectangle);
                }

                typizedShape.FillColor = this.lastSelectedFillColor;
                typizedShape.BorderColor = this.lastSelectedBorderColor;

                shapeList.Add(typizedShape);
            }

            this.dialogProcessor.ShapeList = shapeList;            

            this.viewPort.Invalidate();
        }
    }
}
