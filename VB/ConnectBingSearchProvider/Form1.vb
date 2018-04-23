Imports DevExpress.XtraMap
Imports System.Windows.Forms

Namespace ConnectBingSearchProvider
    Partial Public Class Form1
        Inherits Form

        Private Const bingKey As String = "YOUR BING KEY HERE"

        Private ReadOnly Property SearchLayer() As InformationLayer
            Get
                Return CType(mapControl1.Layers("SearchLayer"), InformationLayer)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            Dim searchProvider As New BingSearchDataProvider() With {.BingKey = bingKey}

            ' Customize the search options.
            searchProvider.SearchOptions.DistanceUnit = DistanceMeasureUnit.Mile
            searchProvider.SearchOptions.SearchRadius = 200
            searchProvider.SearchOptions.ResultsCount = 5

            SearchLayer.DataProvider = searchProvider
        End Sub
    End Class
End Namespace
