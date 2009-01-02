/*
 * Automatically generated, do not edit this file directly
 */

using Mono;
using System;
using System.Reflection;
using System.Collections.Generic;

namespace Mono {
	static partial class Types {
		private static void CreateNativeTypes ()
		{
			Assembly agclr = Helper.Agclr;
			Type t;
			try {
				if (agclr == null) {
					Console.Error.WriteLine ("Types.CreateNativeTypes (): Helper.Agclr () has not been set yet.");
					return;
				}
				t = agclr.GetType ("Microsoft.Internal.TextBoxView", true); 
				types.Add (t, new ManagedType (t, Kind.TEXTBOXVIEW));
				t = agclr.GetType ("Mono.DispatcherTimer", true); 
				types.Add (t, new ManagedType (t, Kind.DISPATCHERTIMER));
				t = agclr.GetType ("System.Windows.ApplicationInternal", true); 
				types.Add (t, new ManagedType (t, Kind.APPLICATION));
				t = agclr.GetType ("System.Windows.AssemblyPart", true); 
				types.Add (t, new ManagedType (t, Kind.ASSEMBLYPART));
				t = agclr.GetType ("System.Windows.AssemblyPartCollection", true); 
				types.Add (t, new ManagedType (t, Kind.ASSEMBLYPART_COLLECTION));
				t = agclr.GetType ("System.Windows.DataTemplate", true); 
				types.Add (t, new ManagedType (t, Kind.DATATEMPLATE));
				t = agclr.GetType ("System.Windows.DependencyObject", true); 
				types.Add (t, new ManagedType (t, Kind.DEPENDENCY_OBJECT));
				t = agclr.GetType ("System.Windows.Deployment", true); 
				types.Add (t, new ManagedType (t, Kind.DEPLOYMENT));
				t = agclr.GetType ("System.Windows.EventTrigger", true); 
				types.Add (t, new ManagedType (t, Kind.EVENTTRIGGER));
				t = agclr.GetType ("System.Windows.FrameworkElement", true); 
				types.Add (t, new ManagedType (t, Kind.FRAMEWORKELEMENT));
				t = agclr.GetType ("System.Windows.FrameworkTemplate", true); 
				types.Add (t, new ManagedType (t, Kind.FRAMEWORKTEMPLATE));
				t = agclr.GetType ("System.Windows.PresentationFrameworkCollection`1", true); 
				types.Add (t, new ManagedType (t, Kind.COLLECTION));
				t = agclr.GetType ("System.Windows.ResourceDictionary", true); 
				types.Add (t, new ManagedType (t, Kind.RESOURCE_DICTIONARY));
				t = agclr.GetType ("System.Windows.Setter", true); 
				types.Add (t, new ManagedType (t, Kind.SETTER));
				t = agclr.GetType ("System.Windows.SetterBase", true); 
				types.Add (t, new ManagedType (t, Kind.SETTERBASE));
				t = agclr.GetType ("System.Windows.SetterBaseCollection", true); 
				types.Add (t, new ManagedType (t, Kind.SETTERBASE_COLLECTION));
				t = agclr.GetType ("System.Windows.Style", true); 
				types.Add (t, new ManagedType (t, Kind.STYLE));
				t = agclr.GetType ("System.Windows.TriggerAction", true); 
				types.Add (t, new ManagedType (t, Kind.TRIGGERACTION));
				t = agclr.GetType ("System.Windows.TriggerActionCollection", true); 
				types.Add (t, new ManagedType (t, Kind.TRIGGERACTION_COLLECTION));
				t = agclr.GetType ("System.Windows.TriggerBase", true); 
				types.Add (t, new ManagedType (t, Kind.TRIGGERBASE));
				t = agclr.GetType ("System.Windows.TriggerCollection", true); 
				types.Add (t, new ManagedType (t, Kind.TRIGGER_COLLECTION));
				t = agclr.GetType ("System.Windows.UIElement", true); 
				types.Add (t, new ManagedType (t, Kind.UIELEMENT));
				t = agclr.GetType ("System.Windows.Controls.Border", true); 
				types.Add (t, new ManagedType (t, Kind.BORDER));
				t = agclr.GetType ("System.Windows.Controls.Canvas", true); 
				types.Add (t, new ManagedType (t, Kind.CANVAS));
				t = agclr.GetType ("System.Windows.Controls.ColumnDefinition", true); 
				types.Add (t, new ManagedType (t, Kind.COLUMNDEFINITION));
				t = agclr.GetType ("System.Windows.Controls.ColumnDefinitionCollection", true); 
				types.Add (t, new ManagedType (t, Kind.COLUMNDEFINITION_COLLECTION));
				t = agclr.GetType ("System.Windows.Controls.Control", true); 
				types.Add (t, new ManagedType (t, Kind.CONTROL));
				t = agclr.GetType ("System.Windows.Controls.ControlTemplate", true); 
				types.Add (t, new ManagedType (t, Kind.CONTROLTEMPLATE));
				t = agclr.GetType ("System.Windows.Controls.Grid", true); 
				types.Add (t, new ManagedType (t, Kind.GRID));
				t = agclr.GetType ("System.Windows.Controls.Image", true); 
				types.Add (t, new ManagedType (t, Kind.IMAGE));
				t = agclr.GetType ("System.Windows.Controls.InkPresenter", true); 
				types.Add (t, new ManagedType (t, Kind.INKPRESENTER));
				t = agclr.GetType ("System.Windows.Controls.MediaElement", true); 
				types.Add (t, new ManagedType (t, Kind.MEDIAELEMENT));
				t = agclr.GetType ("System.Windows.Controls.MultiScaleImage", true); 
				types.Add (t, new ManagedType (t, Kind.MULTISCALEIMAGE));
				t = agclr.GetType ("System.Windows.Controls.MultiScaleSubImage", true); 
				types.Add (t, new ManagedType (t, Kind.MULTISCALESUBIMAGE));
				t = agclr.GetType ("System.Windows.Controls.Panel", true); 
				types.Add (t, new ManagedType (t, Kind.PANEL));
				t = agclr.GetType ("System.Windows.Controls.PasswordBox", true); 
				types.Add (t, new ManagedType (t, Kind.PASSWORDBOX));
				t = agclr.GetType ("System.Windows.Controls.RowDefinition", true); 
				types.Add (t, new ManagedType (t, Kind.ROWDEFINITION));
				t = agclr.GetType ("System.Windows.Controls.RowDefinitionCollection", true); 
				types.Add (t, new ManagedType (t, Kind.ROWDEFINITION_COLLECTION));
				t = agclr.GetType ("System.Windows.Controls.StackPanel", true); 
				types.Add (t, new ManagedType (t, Kind.STACKPANEL));
				t = agclr.GetType ("System.Windows.Controls.TextBlock", true); 
				types.Add (t, new ManagedType (t, Kind.TEXTBLOCK));
				t = agclr.GetType ("System.Windows.Controls.TextBox", true); 
				types.Add (t, new ManagedType (t, Kind.TEXTBOX));
				t = agclr.GetType ("System.Windows.Controls.UIElementCollection", true); 
				types.Add (t, new ManagedType (t, Kind.UIELEMENT_COLLECTION));
				t = agclr.GetType ("System.Windows.Controls.UserControl", true); 
				types.Add (t, new ManagedType (t, Kind.USERCONTROL));
				t = agclr.GetType ("System.Windows.Documents.Glyphs", true); 
				types.Add (t, new ManagedType (t, Kind.GLYPHS));
				t = agclr.GetType ("System.Windows.Documents.Inline", true); 
				types.Add (t, new ManagedType (t, Kind.INLINE));
				t = agclr.GetType ("System.Windows.Documents.InlineCollection", true); 
				types.Add (t, new ManagedType (t, Kind.INLINE_COLLECTION));
				t = agclr.GetType ("System.Windows.Documents.LineBreak", true); 
				types.Add (t, new ManagedType (t, Kind.LINEBREAK));
				t = agclr.GetType ("System.Windows.Documents.Run", true); 
				types.Add (t, new ManagedType (t, Kind.RUN));
				t = agclr.GetType ("System.Windows.Ink.DrawingAttributes", true); 
				types.Add (t, new ManagedType (t, Kind.DRAWINGATTRIBUTES));
				t = agclr.GetType ("System.Windows.Ink.Stroke", true); 
				types.Add (t, new ManagedType (t, Kind.STROKE));
				t = agclr.GetType ("System.Windows.Ink.StrokeCollection", true); 
				types.Add (t, new ManagedType (t, Kind.STROKE_COLLECTION));
				t = agclr.GetType ("System.Windows.Input.InputMethod", true); 
				types.Add (t, new ManagedType (t, Kind.INPUTMETHOD));
				t = agclr.GetType ("System.Windows.Input.StylusPointCollection", true); 
				types.Add (t, new ManagedType (t, Kind.STYLUSPOINT_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.ArcSegment", true); 
				types.Add (t, new ManagedType (t, Kind.ARCSEGMENT));
				t = agclr.GetType ("System.Windows.Media.BezierSegment", true); 
				types.Add (t, new ManagedType (t, Kind.BEZIERSEGMENT));
				t = agclr.GetType ("System.Windows.Media.Brush", true); 
				types.Add (t, new ManagedType (t, Kind.BRUSH));
				t = agclr.GetType ("System.Windows.Media.DeepZoomImageTileSource", true); 
				types.Add (t, new ManagedType (t, Kind.DEEPZOOMIMAGETILESOURCE));
				t = agclr.GetType ("System.Windows.Media.DoubleCollection", true); 
				types.Add (t, new ManagedType (t, Kind.DOUBLE_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.EllipseGeometry", true); 
				types.Add (t, new ManagedType (t, Kind.ELLIPSEGEOMETRY));
				t = agclr.GetType ("System.Windows.Media.GeneralTransform", true); 
				types.Add (t, new ManagedType (t, Kind.GENERALTRANSFORM));
				t = agclr.GetType ("System.Windows.Media.Geometry", true); 
				types.Add (t, new ManagedType (t, Kind.GEOMETRY));
				t = agclr.GetType ("System.Windows.Media.GeometryCollection", true); 
				types.Add (t, new ManagedType (t, Kind.GEOMETRY_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.GeometryGroup", true); 
				types.Add (t, new ManagedType (t, Kind.GEOMETRYGROUP));
				t = agclr.GetType ("System.Windows.Media.GradientBrush", true); 
				types.Add (t, new ManagedType (t, Kind.GRADIENTBRUSH));
				t = agclr.GetType ("System.Windows.Media.GradientStop", true); 
				types.Add (t, new ManagedType (t, Kind.GRADIENTSTOP));
				t = agclr.GetType ("System.Windows.Media.GradientStopCollection", true); 
				types.Add (t, new ManagedType (t, Kind.GRADIENTSTOP_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.ImageBrush", true); 
				types.Add (t, new ManagedType (t, Kind.IMAGEBRUSH));
				t = agclr.GetType ("System.Windows.Media.LinearGradientBrush", true); 
				types.Add (t, new ManagedType (t, Kind.LINEARGRADIENTBRUSH));
				t = agclr.GetType ("System.Windows.Media.LineGeometry", true); 
				types.Add (t, new ManagedType (t, Kind.LINEGEOMETRY));
				t = agclr.GetType ("System.Windows.Media.LineSegment", true); 
				types.Add (t, new ManagedType (t, Kind.LINESEGMENT));
				t = agclr.GetType ("System.Windows.Media.MatrixTransform", true); 
				types.Add (t, new ManagedType (t, Kind.MATRIXTRANSFORM));
				t = agclr.GetType ("System.Windows.Media.MultiScaleTileSource", true); 
				types.Add (t, new ManagedType (t, Kind.MULTISCALETILESOURCE));
				t = agclr.GetType ("System.Windows.Media.PathFigure", true); 
				types.Add (t, new ManagedType (t, Kind.PATHFIGURE));
				t = agclr.GetType ("System.Windows.Media.PathFigureCollection", true); 
				types.Add (t, new ManagedType (t, Kind.PATHFIGURE_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.PathGeometry", true); 
				types.Add (t, new ManagedType (t, Kind.PATHGEOMETRY));
				t = agclr.GetType ("System.Windows.Media.PathSegment", true); 
				types.Add (t, new ManagedType (t, Kind.PATHSEGMENT));
				t = agclr.GetType ("System.Windows.Media.PathSegmentCollection", true); 
				types.Add (t, new ManagedType (t, Kind.PATHSEGMENT_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.PointCollection", true); 
				types.Add (t, new ManagedType (t, Kind.POINT_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.PolyBezierSegment", true); 
				types.Add (t, new ManagedType (t, Kind.POLYBEZIERSEGMENT));
				t = agclr.GetType ("System.Windows.Media.PolyLineSegment", true); 
				types.Add (t, new ManagedType (t, Kind.POLYLINESEGMENT));
				t = agclr.GetType ("System.Windows.Media.PolyQuadraticBezierSegment", true); 
				types.Add (t, new ManagedType (t, Kind.POLYQUADRATICBEZIERSEGMENT));
				t = agclr.GetType ("System.Windows.Media.QuadraticBezierSegment", true); 
				types.Add (t, new ManagedType (t, Kind.QUADRATICBEZIERSEGMENT));
				t = agclr.GetType ("System.Windows.Media.RadialGradientBrush", true); 
				types.Add (t, new ManagedType (t, Kind.RADIALGRADIENTBRUSH));
				t = agclr.GetType ("System.Windows.Media.RectangleGeometry", true); 
				types.Add (t, new ManagedType (t, Kind.RECTANGLEGEOMETRY));
				t = agclr.GetType ("System.Windows.Media.RotateTransform", true); 
				types.Add (t, new ManagedType (t, Kind.ROTATETRANSFORM));
				t = agclr.GetType ("System.Windows.Media.ScaleTransform", true); 
				types.Add (t, new ManagedType (t, Kind.SCALETRANSFORM));
				t = agclr.GetType ("System.Windows.Media.SkewTransform", true); 
				types.Add (t, new ManagedType (t, Kind.SKEWTRANSFORM));
				t = agclr.GetType ("System.Windows.Media.SolidColorBrush", true); 
				types.Add (t, new ManagedType (t, Kind.SOLIDCOLORBRUSH));
				t = agclr.GetType ("System.Windows.Media.TileBrush", true); 
				types.Add (t, new ManagedType (t, Kind.TILEBRUSH));
				t = agclr.GetType ("System.Windows.Media.TimelineMarker", true); 
				types.Add (t, new ManagedType (t, Kind.TIMELINEMARKER));
				t = agclr.GetType ("System.Windows.Media.TimelineMarkerCollection", true); 
				types.Add (t, new ManagedType (t, Kind.TIMELINEMARKER_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.Transform", true); 
				types.Add (t, new ManagedType (t, Kind.TRANSFORM));
				t = agclr.GetType ("System.Windows.Media.TransformCollection", true); 
				types.Add (t, new ManagedType (t, Kind.TRANSFORM_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.TransformGroup", true); 
				types.Add (t, new ManagedType (t, Kind.TRANSFORMGROUP));
				t = agclr.GetType ("System.Windows.Media.TranslateTransform", true); 
				types.Add (t, new ManagedType (t, Kind.TRANSLATETRANSFORM));
				t = agclr.GetType ("System.Windows.Media.VideoBrush", true); 
				types.Add (t, new ManagedType (t, Kind.VIDEOBRUSH));
				t = agclr.GetType ("System.Windows.Media.Animation.BeginStoryboard", true); 
				types.Add (t, new ManagedType (t, Kind.BEGINSTORYBOARD));
				t = agclr.GetType ("System.Windows.Media.Animation.ColorAnimation", true); 
				types.Add (t, new ManagedType (t, Kind.COLORANIMATION));
				t = agclr.GetType ("System.Windows.Media.Animation.ColorAnimationUsingKeyFrames", true); 
				types.Add (t, new ManagedType (t, Kind.COLORANIMATIONUSINGKEYFRAMES));
				t = agclr.GetType ("System.Windows.Media.Animation.ColorKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.COLORKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.ColorKeyFrameCollection", true); 
				types.Add (t, new ManagedType (t, Kind.COLORKEYFRAME_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.Animation.DiscreteColorKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.DISCRETECOLORKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.DiscreteDoubleKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.DISCRETEDOUBLEKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.DiscreteObjectKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.DISCRETEOBJECTKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.DiscretePointKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.DISCRETEPOINTKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.DoubleAnimation", true); 
				types.Add (t, new ManagedType (t, Kind.DOUBLEANIMATION));
				t = agclr.GetType ("System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames", true); 
				types.Add (t, new ManagedType (t, Kind.DOUBLEANIMATIONUSINGKEYFRAMES));
				t = agclr.GetType ("System.Windows.Media.Animation.DoubleKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.DOUBLEKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.DoubleKeyFrameCollection", true); 
				types.Add (t, new ManagedType (t, Kind.DOUBLEKEYFRAME_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.Animation.KeySpline", true); 
				types.Add (t, new ManagedType (t, Kind.KEYSPLINE));
				t = agclr.GetType ("System.Windows.Media.Animation.LinearColorKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.LINEARCOLORKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.LinearDoubleKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.LINEARDOUBLEKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.LinearPointKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.LINEARPOINTKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames", true); 
				types.Add (t, new ManagedType (t, Kind.OBJECTANIMATIONUSINGKEYFRAMES));
				t = agclr.GetType ("System.Windows.Media.Animation.ObjectKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.OBJECTKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.ObjectKeyFrameCollection", true); 
				types.Add (t, new ManagedType (t, Kind.OBJECTKEYFRAME_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.Animation.PointAnimation", true); 
				types.Add (t, new ManagedType (t, Kind.POINTANIMATION));
				t = agclr.GetType ("System.Windows.Media.Animation.PointAnimationUsingKeyFrames", true); 
				types.Add (t, new ManagedType (t, Kind.POINTANIMATIONUSINGKEYFRAMES));
				t = agclr.GetType ("System.Windows.Media.Animation.PointKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.POINTKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.PointKeyFrameCollection", true); 
				types.Add (t, new ManagedType (t, Kind.POINTKEYFRAME_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.Animation.SplineColorKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.SPLINECOLORKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.SplineDoubleKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.SPLINEDOUBLEKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.SplinePointKeyFrame", true); 
				types.Add (t, new ManagedType (t, Kind.SPLINEPOINTKEYFRAME));
				t = agclr.GetType ("System.Windows.Media.Animation.Storyboard", true); 
				types.Add (t, new ManagedType (t, Kind.STORYBOARD));
				t = agclr.GetType ("System.Windows.Media.Animation.Timeline", true); 
				types.Add (t, new ManagedType (t, Kind.TIMELINE));
				t = agclr.GetType ("System.Windows.Media.Animation.TimelineCollection", true); 
				types.Add (t, new ManagedType (t, Kind.TIMELINE_COLLECTION));
				t = agclr.GetType ("System.Windows.Media.Imaging.BitmapImage", true); 
				types.Add (t, new ManagedType (t, Kind.BITMAPIMAGE));
				t = agclr.GetType ("System.Windows.Shapes.Ellipse", true); 
				types.Add (t, new ManagedType (t, Kind.ELLIPSE));
				t = agclr.GetType ("System.Windows.Shapes.Line", true); 
				types.Add (t, new ManagedType (t, Kind.LINE));
				t = agclr.GetType ("System.Windows.Shapes.Path", true); 
				types.Add (t, new ManagedType (t, Kind.PATH));
				t = agclr.GetType ("System.Windows.Shapes.Polygon", true); 
				types.Add (t, new ManagedType (t, Kind.POLYGON));
				t = agclr.GetType ("System.Windows.Shapes.Polyline", true); 
				types.Add (t, new ManagedType (t, Kind.POLYLINE));
				t = agclr.GetType ("System.Windows.Shapes.Rectangle", true); 
				types.Add (t, new ManagedType (t, Kind.RECTANGLE));
				t = agclr.GetType ("System.Windows.Shapes.Shape", true); 
				types.Add (t, new ManagedType (t, Kind.SHAPE));
				t = typeof (char);
				types.Add (t, new ManagedType (t, Kind.INT32));
				t = typeof (object);
				types.Add (t, new ManagedType (t, Kind.OBJECT));
				t = typeof (bool);
				types.Add (t, new ManagedType (t, Kind.BOOL));
				t = typeof (double);
				types.Add (t, new ManagedType (t, Kind.DOUBLE));
				t = typeof (ulong);
				types.Add (t, new ManagedType (t, Kind.UINT64));
				t = typeof (long);
				types.Add (t, new ManagedType (t, Kind.INT64));
				t = typeof (uint);
				types.Add (t, new ManagedType (t, Kind.UINT32));
				t = typeof (int);
				types.Add (t, new ManagedType (t, Kind.INT32));
				t = typeof (string);
				types.Add (t, new ManagedType (t, Kind.STRING));
				t = typeof (TimeSpan);
				types.Add (t, new ManagedType (t, Kind.TIMESPAN));
			} catch (Exception ex) {
				Console.WriteLine ("There was an error while loading native types: " + ex.ToString ());
			}
		}
	}
}
