using DevExpress.XtraMap;
using System.Windows.Forms;

namespace ConnectBingSearchProvider {
    public partial class Form1 : Form {
        const string bingKey = "YOUR BING KEY HERE";

        InformationLayer SearchLayer { 
            get {
                return (InformationLayer)mapControl1.Layers["SearchLayer"];
            }
        }

        public Form1() {
            InitializeComponent();

            BingSearchDataProvider searchProvider = new BingSearchDataProvider() { 
                BingKey = bingKey 
            };
            
            searchProvider.SearchOptions.ResultsCount = 5;

            SearchLayer.DataProvider = searchProvider;
        }      
    }
}
