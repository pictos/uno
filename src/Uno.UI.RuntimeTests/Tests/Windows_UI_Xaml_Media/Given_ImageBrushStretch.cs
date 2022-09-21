using System;
using System.Drawing;
using System.Linq;
using NUnit.Framework;
using Uno.UI.RuntimeTests.Helpers;
using System.Threading.Tasks;
using Uno.UI.RuntimeTests.Extensions;
using Windows.UI.Xaml.Media;
using static Private.Infrastructure.TestServices;
using Windows.UI.Xaml.Media.Imaging;
using Color = System.Drawing.Color;
using Private.Infrastructure;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.Foundation;
using Windows.UI.Xaml.Shapes;
using Rectangle = Windows.UI.Xaml.Shapes.Rectangle;
using ImageBrush = Windows.UI.Xaml.Media.ImageBrush;
using static Windows.UI.Xaml.Controls.CollectionChangedOperation;

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

		//#if __SKIA__
		[TestMethod]
		[RunsOnUIThread]

		public async Task When_Stretch()
		{

			var brush = new ImageBrush();
			brush.Stretch = Stretch.Fill;

			var rect = new Rectangle()
			{
				Fill = brush,
				Height = 50,
				Width = 50,
				HorizontalAlignment = HorizontalAlignment.Left,
				VerticalAlignment = VerticalAlignment.Top,
			};

			var border = new Border()
			{
				Child = rect,
			};

			TestServices.WindowHelper.WindowContent = border;

			await TestServices.WindowHelper.WaitForIdle();

			await TestServices.WindowHelper.WaitForIdle();

			WindowHelper.WaitForLoaded(border);


			var renderer = new RenderTargetBitmap();

			await renderer.RenderAsync(border);

			var fill = new RawBitmap(renderer, border);

			Assert.IsNotNull(fill);

			double centerX = fill.Width / 2;
			double centerY = fill.Height / 2;

			// All edges are red-ish
			await ImageAssert.HasColorAtChild(fill, border, centerX, fill.Height - 6, Redish, tolerance: 5);
			await ImageAssert.HasColorAtChild(fill,border, centerX, 6, Redish, tolerance: 5);
			await ImageAssert.HasColorAtChild(fill, border,  6, centerY, Redish, tolerance: 5);
			await ImageAssert.HasColorAtChild(fill, border, fill.Width - 6, centerY, Redish, tolerance: 5);

			brush.Stretch = Stretch.Uniform;
			await WindowHelper.WaitForIdle();
			await renderer.RenderAsync(border);
			var uniFill = new RawBitmap(renderer, border);
			await WindowHelper.WaitForIdle();
			centerX = uniFill.Width / 2;
			centerY = uniFill.Height / 2;

			// Top and bottom are red-ish. Left and right are yellow-ish
			await ImageAssert.HasColorAt(uniformToFill, width, height + 6, Redish, tolerance: 5);
			//	ImageAssert.HasColorAt(uniformToFill, centerX, 0 + 6, Redish, tolerance: 5);
			//	ImageAssert.HasColorAt(uniformToFill, 6, centerY, Yellowish, tolerance: 5);
			//	ImageAssert.HasColorAt(uniformToFill, width - 6, centerY, Yellowish, tolerance: 5);
			//	
		}

		//	[TestMethod]
		////	public async Task When_Stretch_Uniform()
		//	{

		//		var brush = new ImageBrush()
		//		{
		//			Stretch = Stretch.Uniform,
		//		};
		//		WindowHelper.WindowContent = brush;
		//		await WindowHelper.WaitForIdle();
		//		await WindowHelper.WaitForIdle();
		//		var renderer = new RenderTargetBitmap();
		//		await WindowHelper.WaitForIdle();
		//		await renderer.RenderAsync(brush);
		//		var uniform = new RawBitmap(renderer, brush);
		//		await WindowHelper.WaitForIdle();
		//		float width = uniform.Width;
		//		float height = uniform.Height;
		//		float centerX = width / 2;
		//		float centerY = height / 2;

		// Top and bottom are same as backround. Left and right are red-ish
		//		ImageAssert.HasColorAt(uniform, centerX, height + 6, White, tolerance: 5);
		//		ImageAssert.HasColorAt(uniform, centerX, 6, White, tolerance: 5);
		//		ImageAssert.HasColorAt(uniform, 6, centerY, Redish, tolerance: 5);
		//		ImageAssert.HasColorAt(uniform, width - 6, centerY, Redish, tolerance: 5);
		//		Assert.IsTrue(true);
		//	}

		// Everything is green-ish
		//ImageAssert.HasColorAt(screenshot, none.CenterX, none.Y + 6, Greenish, tolerance: 5);
		//ImageAssert.HasColorAt(screenshot, none.CenterX, none.Bottom - 6, Greenish, tolerance: 5);
		//ImageAssert.HasColorAt(screenshot, none.X + 6, none.CenterY, Greenish, tolerance: 5);
		//ImageAssert.HasColorAt(screenshot, none.Right - 6, none.CenterY, Greenish, tolerance: 5);
		//}
		//#endif
	}
}

