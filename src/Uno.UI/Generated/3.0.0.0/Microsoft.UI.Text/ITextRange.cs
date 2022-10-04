#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Text
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITextRange 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		char Character
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Text.ITextCharacterFormat CharacterFormat
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int EndPosition
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Text.ITextRange FormattedText
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Text.RangeGravity Gravity
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int Length
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		string Link
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Text.ITextParagraphFormat ParagraphFormat
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int StartPosition
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int StoryLength
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		string Text
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Text.ITextRange.Character.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.Character.set
		// Forced skipping of method Microsoft.UI.Text.ITextRange.CharacterFormat.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.CharacterFormat.set
		// Forced skipping of method Microsoft.UI.Text.ITextRange.FormattedText.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.FormattedText.set
		// Forced skipping of method Microsoft.UI.Text.ITextRange.EndPosition.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.EndPosition.set
		// Forced skipping of method Microsoft.UI.Text.ITextRange.Gravity.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.Gravity.set
		// Forced skipping of method Microsoft.UI.Text.ITextRange.Length.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.Link.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.Link.set
		// Forced skipping of method Microsoft.UI.Text.ITextRange.ParagraphFormat.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.ParagraphFormat.set
		// Forced skipping of method Microsoft.UI.Text.ITextRange.StartPosition.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.StartPosition.set
		// Forced skipping of method Microsoft.UI.Text.ITextRange.StoryLength.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.Text.get
		// Forced skipping of method Microsoft.UI.Text.ITextRange.Text.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool CanPaste( int format);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void ChangeCase( global::Microsoft.UI.Text.LetterCase value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void Collapse( bool value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void Copy();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void Cut();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int Delete( global::Microsoft.UI.Text.TextRangeUnit unit,  int count);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int EndOf( global::Microsoft.UI.Text.TextRangeUnit unit,  bool extend);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int Expand( global::Microsoft.UI.Text.TextRangeUnit unit);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int FindText( string value,  int scanLength,  global::Microsoft.UI.Text.FindOptions options);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void GetCharacterUtf32(out uint value,  int offset);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Text.ITextRange GetClone();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int GetIndex( global::Microsoft.UI.Text.TextRangeUnit unit);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void GetPoint( global::Microsoft.UI.Text.HorizontalCharacterAlignment horizontalAlign,  global::Microsoft.UI.Text.VerticalCharacterAlignment verticalAlign,  global::Microsoft.UI.Text.PointOptions options, out global::Windows.Foundation.Point point);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void GetRect( global::Microsoft.UI.Text.PointOptions options, out global::Windows.Foundation.Rect rect, out int hit);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void GetText( global::Microsoft.UI.Text.TextGetOptions options, out string value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void GetTextViaStream( global::Microsoft.UI.Text.TextGetOptions options,  global::Windows.Storage.Streams.IRandomAccessStream value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool InRange( global::Microsoft.UI.Text.ITextRange range);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void InsertImage( int width,  int height,  int ascent,  global::Microsoft.UI.Text.VerticalCharacterAlignment verticalAlign,  string alternateText,  global::Windows.Storage.Streams.IRandomAccessStream value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool InStory( global::Microsoft.UI.Text.ITextRange range);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		bool IsEqual( global::Microsoft.UI.Text.ITextRange range);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int Move( global::Microsoft.UI.Text.TextRangeUnit unit,  int count);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int MoveEnd( global::Microsoft.UI.Text.TextRangeUnit unit,  int count);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int MoveStart( global::Microsoft.UI.Text.TextRangeUnit unit,  int count);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void Paste( int format);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void ScrollIntoView( global::Microsoft.UI.Text.PointOptions value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void MatchSelection();
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void SetIndex( global::Microsoft.UI.Text.TextRangeUnit unit,  int index,  bool extend);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void SetPoint( global::Windows.Foundation.Point point,  global::Microsoft.UI.Text.PointOptions options,  bool extend);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void SetRange( int startPosition,  int endPosition);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void SetText( global::Microsoft.UI.Text.TextSetOptions options,  string value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void SetTextViaStream( global::Microsoft.UI.Text.TextSetOptions options,  global::Windows.Storage.Streams.IRandomAccessStream value);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int StartOf( global::Microsoft.UI.Text.TextRangeUnit unit,  bool extend);
		#endif
	}
}
