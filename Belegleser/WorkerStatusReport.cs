using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belegleser
{
    class WorkerStatusReport
    {
        private int? progress;
        private string template;
        private Image image;

        public WorkerStatusReport(int? progress, string template, Image img)
        {
            this.progress = progress;
            this.template = template;
            this.image = img;
        }

        public int? Progress
        {
            get { return this.progress; }
            set { this.progress = value; }
        }

        public string Template
        {
            get { return this.template; }
            set { this.template = value; }
        }

        public Image Image
        {
            get { return this.image; }
            set { this.image = value; }
        }
    }
}
