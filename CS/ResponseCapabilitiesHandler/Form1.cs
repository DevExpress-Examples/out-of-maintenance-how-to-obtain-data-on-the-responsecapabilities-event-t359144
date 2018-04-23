using DevExpress.XtraMap;
using System.Windows.Forms;

namespace ResponseCapabilitiesHandler {
    public partial class Form1 : Form {
        ImageLayer WmsLayer {
            get { return (ImageLayer)mapControl.Layers["WmsImageLayer"]; }
        }
        WmsDataProvider Provider {
            get { return WmsLayer.DataProvider as WmsDataProvider; }
        }
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e) {
            // Handle the ResponseCapabilities event.
            Provider.ResponseCapabilities += OnResponseCapabalities;
        }
        void OnResponseCapabalities(object sender, CapabilitiesResponsedEventArgs e) {
            // Specify an active layer for the map control.
            Provider.ActiveLayerName = e.Layers[0].Name;
            // Recieve information on the active layer.
            label1.Text = string.Format("Layer name: {0}, Layer title: {1}",  e.Layers[0].Name, e.Layers[0].Title);           
        }
    }
}
