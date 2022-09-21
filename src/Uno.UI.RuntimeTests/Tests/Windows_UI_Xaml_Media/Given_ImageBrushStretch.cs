using System;
using System.Threading.Tasks;
using FluentAssertions.Formatting;
using Private.Infrastructure;
using Uno.UI.RuntimeTests.Helpers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using static Private.Infrastructure.TestServices;
using ImageBrush = Windows.UI.Xaml.Media.ImageBrush;
using Grid = Windows.UI.Xaml.Controls.Grid;
using Rectangle = Windows.UI.Xaml.Shapes.Rectangle;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Media
{
	[TestClass]
	[RunsOnUIThread]
	public class Given_ImageBrushStretch
	{
		private const string Redish = "#FFEB1C24";
		private const string Yellowish = "#FFFEF200";
		private const string Greenish = "#FF0ED145";
		private const string White = "#FFFFFFFF";

		private const double Width = 50;
		private const double Height = 50;
		private const double CenterX = 25;
		private const double CenterY = 25;



#if __SKIA__
		[TestMethod]
		[RunsOnUIThread]

		public async Task When_Stretch()
		{

			ImageBrush brush = new ImageBrush();

			var SUT = new Grid()
			{
				Height = Height,
				Width = Width,
			};

			SUT.Background = brush;
			brush.Stretch = Stretch.Fill;
			
			TestServices.WindowHelper.WindowContent = SUT;			
			WindowHelper.WaitForLoaded(SUT);

			var renderer = new RenderTargetBitmap();
			var fill = new RawBitmap(renderer, SUT);
			await renderer.RenderAsync(SUT);
			
			await TestServices.WindowHelper.WaitForIdle();
			await TestServices.WindowHelper.WaitForIdle();

			// All edges are red-ish
			await ImageAssert.HasColorAtChild(fill, SUT, CenterX, Height - 1, Yellowish, tolerance: 5);
			await ImageAssert.HasColorAtChild(fill, SUT, CenterX, 1, Redish, tolerance: 5);
			await ImageAssert.HasColorAtChild(fill, SUT,  1, CenterY, Redish, tolerance: 5);
			await ImageAssert.HasColorAtChild(fill, SUT, Width - 1, CenterY, Redish, tolerance: 5);

			brush.Stretch = Stretch.UniformToFill;
			await WindowHelper.WaitForIdle();
			await renderer.RenderAsync(SUT);
			var uniFill = new RawBitmap(renderer, SUT);
			await WindowHelper.WaitForIdle();

			// Top and bottom are red-ish. Left and right are yellow-ish
			await ImageAssert.HasColorAtChild(uniFill, SUT, CenterX, Height - 1, Redish, tolerance: 5);
			await ImageAssert.HasColorAtChild(uniFill, SUT, CenterX, 1, Redish, tolerance: 5);
			await ImageAssert.HasColorAtChild(uniFill, SUT, 1, CenterY, Yellowish, tolerance: 5);
			await ImageAssert.HasColorAtChild(uniFill, SUT, Width - 1, CenterY, Yellowish, tolerance: 5);

			brush.Stretch = Stretch.UniformToFill;
			await WindowHelper.WaitForIdle();
			await renderer.RenderAsync(SUT);
			var uniform = new RawBitmap(renderer, SUT);
			await WindowHelper.WaitForIdle();

			// Top and bottom are same as backround. Left and right are red-ish
			await ImageAssert.HasColorAtChild(uniform, SUT, CenterX, Height + 1, White, tolerance: 5);
			await ImageAssert.HasColorAtChild(uniform, SUT, CenterX, 1, White, tolerance: 5);//Test devrait plante true white
		    await ImageAssert.HasColorAtChild(uniform, SUT, 1, CenterY, Redish, tolerance: 5);
			await ImageAssert.HasColorAtChild(uniform,SUT, Width - 1, CenterY, Redish, tolerance: 5);

			brush.Stretch = Stretch.None;
			await WindowHelper.WaitForIdle();
			await renderer.RenderAsync(SUT);
			var none = new RawBitmap(renderer, SUT);
			await WindowHelper.WaitForIdle();

			// Everything is green-ish
			await ImageAssert.HasColorAtChild(none, SUT, CenterX, Height - 1, Greenish, tolerance: 5);
			await ImageAssert.HasColorAtChild(none, SUT, CenterX, 1, Greenish, tolerance: 5);
			await ImageAssert.HasColorAtChild(none, SUT, 1, CenterY, Greenish, tolerance: 5);
			await ImageAssert.HasColorAtChild(none, SUT, Width - 1, CenterY, Greenish, tolerance: 5);
		}
#endif
	}
}

