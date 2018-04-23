Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace ConnectBingSearchProvider
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Const yourBingKey As String = "INSERT_YOUR_BING_KEY_HERE"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a map control.
			Dim map As New MapControl()

			' Specify the map position on the form.           
			map.Dock = DockStyle.Fill

			' Add the map control to the window.
			Me.Controls.Add(map)

			' Create an image tiles layer and add it to the map.
			Dim tilesLayer As New ImageTilesLayer()
			map.Layers.Add(tilesLayer)

			' Create an information layer and add it to the map.
			Dim infoLayer As New InformationLayer()
			map.Layers.Add(infoLayer)

			' Create a Bing data provider and specify the Bing key.
			Dim bingProvider As New BingMapDataProvider()
			tilesLayer.DataProvider = bingProvider
			bingProvider.BingKey = yourBingKey

			' Create a Bing search data provider and specify the Bing key.
			Dim searchProvider As New BingSearchDataProvider()
			infoLayer.DataProvider = searchProvider
			searchProvider.BingKey = yourBingKey

			' Customize the search options.
			searchProvider.SearchOptions.DistanceUnit = DistanceMeasureUnit.Mile
			searchProvider.SearchOptions.SearchRadius = 200
			searchProvider.SearchOptions.ResultsCount = 5
		End Sub
	End Class
End Namespace
