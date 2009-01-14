/*
 * Automatically generated, do not edit this file directly
 */

using Mono;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Microsoft.Internal {
	partial class TextBoxView {
		public TextBoxView () : base (NativeMethods.text_box_view_new ()) {}
		internal TextBoxView (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TEXTBOXVIEW; }
	}
}

namespace Mono {
	partial class DispatcherTimer {
		public DispatcherTimer () : base (NativeMethods.dispatcher_timer_new ()) {}
		internal DispatcherTimer (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DISPATCHERTIMER; }
	}
}

namespace System.Windows {
	partial class ApplicationInternal {
		public ApplicationInternal () : base (NativeMethods.application_new ()) {}
		internal ApplicationInternal (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.APPLICATION; }
	}

	partial class AssemblyPart {
		public AssemblyPart () : base (NativeMethods.assembly_part_new ()) {}
		internal AssemblyPart (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.ASSEMBLYPART; }
	}

	partial class AssemblyPartCollection {
		public AssemblyPartCollection () : base (NativeMethods.assembly_part_collection_new ()) {}
		internal AssemblyPartCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.ASSEMBLYPART_COLLECTION; }
	}

	partial class DataTemplate {
		public DataTemplate () : base (NativeMethods.data_template_new ()) {}
		internal DataTemplate (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DATATEMPLATE; }
	}

	partial class Deployment {
		public Deployment () : base (NativeMethods.deployment_new ()) {}
		internal Deployment (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DEPLOYMENT; }
	}

	partial class EventTrigger {
		public EventTrigger () : base (NativeMethods.event_trigger_new ()) {}
		internal EventTrigger (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.EVENTTRIGGER; }
	}

	partial class FrameworkElement {
		protected FrameworkElement () : base (NativeMethods.framework_element_new ())
		{
			Initialize ();
		}
		internal FrameworkElement (IntPtr raw) : base (raw)
		{
			Initialize ();
		}
		internal override Kind GetKind () { return Kind.FRAMEWORKELEMENT; }
	}

	partial class FrameworkTemplate {
		protected FrameworkTemplate () : base (NativeMethods.framework_template_new ()) {}
		internal FrameworkTemplate (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.FRAMEWORKTEMPLATE; }
	}

	partial class PresentationFrameworkCollection<T> {
		internal PresentationFrameworkCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.COLLECTION; }
	}

	partial class ResourceDictionary {
		public ResourceDictionary () : base (NativeMethods.resource_dictionary_new ()) {}
		internal ResourceDictionary (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.RESOURCE_DICTIONARY; }
	}

	partial class Setter {
		public Setter () : base (NativeMethods.setter_new ()) {}
		internal Setter (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SETTER; }
	}

	partial class SetterBase {
		internal SetterBase () : base (NativeMethods.setter_base_new ()) {}
		internal SetterBase (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SETTERBASE; }
	}

	partial class SetterBaseCollection {
		public SetterBaseCollection () : base (NativeMethods.setter_base_collection_new ()) {}
		internal SetterBaseCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SETTERBASE_COLLECTION; }
	}

	partial class Style {
		public Style () : base (NativeMethods.style_new ()) {}
		internal Style (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.STYLE; }
	}

	partial class TriggerAction {
		internal TriggerAction () : base (NativeMethods.trigger_action_new ()) {}
		internal TriggerAction (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TRIGGERACTION; }
	}

	partial class TriggerActionCollection {
		public TriggerActionCollection () : base (NativeMethods.trigger_action_collection_new ()) {}
		internal TriggerActionCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TRIGGERACTION_COLLECTION; }
	}

	partial class TriggerBase {
		internal TriggerBase () : base (NativeMethods.trigger_base_new ()) {}
		internal TriggerBase (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TRIGGERBASE; }
	}

	partial class TriggerCollection {
		internal TriggerCollection () : base (NativeMethods.trigger_collection_new ()) {}
		internal TriggerCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TRIGGER_COLLECTION; }
	}

	partial class UIElement {
		internal UIElement (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.UIELEMENT; }
	}
}

namespace System.Windows.Controls {
	partial class Border {
		public Border () : base (NativeMethods.border_new ()) {}
		internal Border (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.BORDER; }
	}

	partial class Canvas {
		public Canvas () : base (NativeMethods.canvas_new ()) {}
		internal Canvas (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.CANVAS; }
	}

	partial class ColumnDefinition {
		public ColumnDefinition () : base (NativeMethods.column_definition_new ()) {}
		internal ColumnDefinition (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.COLUMNDEFINITION; }
	}

	partial class ColumnDefinitionCollection {
		internal ColumnDefinitionCollection () : base (NativeMethods.column_definition_collection_new ()) {}
		internal ColumnDefinitionCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.COLUMNDEFINITION_COLLECTION; }
	}

	partial class Control {
		protected Control () : base (NativeMethods.control_new ())
		{
			Initialize ();
		}
		internal Control (IntPtr raw) : base (raw)
		{
			Initialize ();
		}
		internal override Kind GetKind () { return Kind.CONTROL; }
	}

	partial class ControlTemplate {
		public ControlTemplate () : base (NativeMethods.control_template_new ()) {}
		internal ControlTemplate (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.CONTROLTEMPLATE; }
	}

	partial class Grid {
		public Grid () : base (NativeMethods.grid_new ()) {}
		internal Grid (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.GRID; }
	}

	partial class Image {
		public Image () : base (NativeMethods.image_new ()) {}
		internal Image (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.IMAGE; }
	}

	partial class InkPresenter {
		public InkPresenter () : base (NativeMethods.ink_presenter_new ()) {}
		internal InkPresenter (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.INKPRESENTER; }
	}

	partial class ItemCollection {
		internal ItemCollection () : base (NativeMethods.item_collection_new ()) {}
		internal ItemCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.ITEM_COLLECTION; }
	}

	partial class MediaElement {
		public MediaElement () : base (NativeMethods.media_element_new ()) {}
		internal MediaElement (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.MEDIAELEMENT; }
	}

	partial class MultiScaleImage {
		public MultiScaleImage () : base (NativeMethods.multi_scale_image_new ()) {}
		internal MultiScaleImage (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.MULTISCALEIMAGE; }
	}

	partial class MultiScaleSubImage {
		public MultiScaleSubImage () : base (NativeMethods.multi_scale_sub_image_new ()) {}
		internal MultiScaleSubImage (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.MULTISCALESUBIMAGE; }
	}

	partial class Panel {
		protected Panel () : base (NativeMethods.panel_new ()) {}
		internal Panel (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.PANEL; }
	}

	partial class PasswordBox {
		public PasswordBox () : base (NativeMethods.password_box_new ()) {}
		internal PasswordBox (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.PASSWORDBOX; }
	}

	partial class RowDefinition {
		public RowDefinition () : base (NativeMethods.row_definition_new ()) {}
		internal RowDefinition (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.ROWDEFINITION; }
	}

	partial class RowDefinitionCollection {
		internal RowDefinitionCollection () : base (NativeMethods.row_definition_collection_new ()) {}
		internal RowDefinitionCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.ROWDEFINITION_COLLECTION; }
	}

	partial class TextBlock {
		public TextBlock () : base (NativeMethods.text_block_new ()) {}
		internal TextBlock (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TEXTBLOCK; }
	}

	partial class TextBox {
		public TextBox () : base (NativeMethods.text_box_new ())
		{
			Initialize ();
		}
		internal TextBox (IntPtr raw) : base (raw)
		{
			Initialize ();
		}
		internal override Kind GetKind () { return Kind.TEXTBOX; }
	}

	partial class UIElementCollection {
		internal UIElementCollection () : base (NativeMethods.uielement_collection_new ()) {}
		internal UIElementCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.UIELEMENT_COLLECTION; }
	}

	partial class UserControl {
		public UserControl () : base (NativeMethods.user_control_new ()) {}
		internal UserControl (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.USERCONTROL; }
	}
}

namespace System.Windows.Documents {
	partial class Glyphs {
		public Glyphs () : base (NativeMethods.glyphs_new ()) {}
		internal Glyphs (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.GLYPHS; }
	}

	partial class Inline {
		protected Inline () : base (NativeMethods.inline_new ()) {}
		internal Inline (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.INLINE; }
	}

	partial class InlineCollection {
		internal InlineCollection () : base (NativeMethods.inline_collection_new ()) {}
		internal InlineCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.INLINE_COLLECTION; }
	}

	partial class LineBreak {
		public LineBreak () : base (NativeMethods.line_break_new ()) {}
		internal LineBreak (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.LINEBREAK; }
	}

	partial class Run {
		public Run () : base (NativeMethods.run_new ()) {}
		internal Run (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.RUN; }
	}
}

namespace System.Windows.Ink {
	partial class DrawingAttributes {
		public DrawingAttributes () : base (NativeMethods.drawing_attributes_new ()) {}
		internal DrawingAttributes (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DRAWINGATTRIBUTES; }
	}

	partial class Stroke {
		public Stroke () : base (NativeMethods.stroke_new ()) {}
		internal Stroke (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.STROKE; }
	}

	partial class StrokeCollection {
		public StrokeCollection () : base (NativeMethods.stroke_collection_new ()) {}
		internal StrokeCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.STROKE_COLLECTION; }
	}
}

namespace System.Windows.Input {
	partial class InputMethod {
		internal InputMethod () : base (NativeMethods.input_method_new ()) {}
		internal InputMethod (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.INPUTMETHOD; }
	}

	partial class StylusPointCollection {
		public StylusPointCollection () : base (NativeMethods.stylus_point_collection_new ()) {}
		internal StylusPointCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.STYLUSPOINT_COLLECTION; }
	}
}

namespace System.Windows.Media {
	partial class ArcSegment {
		public ArcSegment () : base (NativeMethods.arc_segment_new ()) {}
		internal ArcSegment (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.ARCSEGMENT; }
	}

	partial class BezierSegment {
		public BezierSegment () : base (NativeMethods.bezier_segment_new ()) {}
		internal BezierSegment (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.BEZIERSEGMENT; }
	}

	partial class Brush {
		protected Brush () : base (NativeMethods.brush_new ()) {}
		internal Brush (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.BRUSH; }
	}

	partial class DeepZoomImageTileSource {
		public DeepZoomImageTileSource () : base (NativeMethods.deep_zoom_image_tile_source_new ())
		{
			Initialize ();
		}
		internal DeepZoomImageTileSource (IntPtr raw) : base (raw)
		{
			Initialize ();
		}
		internal override Kind GetKind () { return Kind.DEEPZOOMIMAGETILESOURCE; }
	}

	partial class DoubleCollection {
		public DoubleCollection () : base (NativeMethods.double_collection_new ()) {}
		internal DoubleCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DOUBLE_COLLECTION; }
	}

	partial class EllipseGeometry {
		public EllipseGeometry () : base (NativeMethods.ellipse_geometry_new ()) {}
		internal EllipseGeometry (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.ELLIPSEGEOMETRY; }
	}

	partial class GeneralTransform {
		internal GeneralTransform () : base (NativeMethods.general_transform_new ()) {}
		internal GeneralTransform (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.GENERALTRANSFORM; }
	}

	partial class Geometry {
		internal Geometry () : base (NativeMethods.geometry_new ()) {}
		internal Geometry (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.GEOMETRY; }
	}

	partial class GeometryCollection {
		public GeometryCollection () : base (NativeMethods.geometry_collection_new ()) {}
		internal GeometryCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.GEOMETRY_COLLECTION; }
	}

	partial class GeometryGroup {
		public GeometryGroup () : base (NativeMethods.geometry_group_new ()) {}
		internal GeometryGroup (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.GEOMETRYGROUP; }
	}

	partial class GradientBrush {
		protected GradientBrush () : base (NativeMethods.gradient_brush_new ()) {}
		internal GradientBrush (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.GRADIENTBRUSH; }
	}

	partial class GradientStop {
		public GradientStop () : base (NativeMethods.gradient_stop_new ()) {}
		internal GradientStop (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.GRADIENTSTOP; }
	}

	partial class GradientStopCollection {
		public GradientStopCollection () : base (NativeMethods.gradient_stop_collection_new ()) {}
		internal GradientStopCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.GRADIENTSTOP_COLLECTION; }
	}

	partial class ImageBrush {
		public ImageBrush () : base (NativeMethods.image_brush_new ()) {}
		internal ImageBrush (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.IMAGEBRUSH; }
	}

	partial class LinearGradientBrush {
		public LinearGradientBrush () : base (NativeMethods.linear_gradient_brush_new ()) {}
		internal LinearGradientBrush (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.LINEARGRADIENTBRUSH; }
	}

	partial class LineGeometry {
		public LineGeometry () : base (NativeMethods.line_geometry_new ()) {}
		internal LineGeometry (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.LINEGEOMETRY; }
	}

	partial class LineSegment {
		public LineSegment () : base (NativeMethods.line_segment_new ()) {}
		internal LineSegment (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.LINESEGMENT; }
	}

	partial class MatrixTransform {
		public MatrixTransform () : base (NativeMethods.matrix_transform_new ()) {}
		internal MatrixTransform (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.MATRIXTRANSFORM; }
	}

	partial class MultiScaleTileSource {
		internal MultiScaleTileSource () : base (NativeMethods.multi_scale_tile_source_new ())
		{
			Initialize ();
		}
		internal MultiScaleTileSource (IntPtr raw) : base (raw)
		{
			Initialize ();
		}
		internal override Kind GetKind () { return Kind.MULTISCALETILESOURCE; }
	}

	partial class PathFigure {
		public PathFigure () : base (NativeMethods.path_figure_new ()) {}
		internal PathFigure (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.PATHFIGURE; }
	}

	partial class PathFigureCollection {
		public PathFigureCollection () : base (NativeMethods.path_figure_collection_new ()) {}
		internal PathFigureCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.PATHFIGURE_COLLECTION; }
	}

	partial class PathGeometry {
		public PathGeometry () : base (NativeMethods.path_geometry_new ()) {}
		internal PathGeometry (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.PATHGEOMETRY; }
	}

	partial class PathSegment {
		internal PathSegment () : base (NativeMethods.path_segment_new ()) {}
		internal PathSegment (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.PATHSEGMENT; }
	}

	partial class PathSegmentCollection {
		public PathSegmentCollection () : base (NativeMethods.path_segment_collection_new ()) {}
		internal PathSegmentCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.PATHSEGMENT_COLLECTION; }
	}

	partial class PointCollection {
		public PointCollection () : base (NativeMethods.point_collection_new ()) {}
		internal PointCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POINT_COLLECTION; }
	}

	partial class PolyBezierSegment {
		public PolyBezierSegment () : base (NativeMethods.poly_bezier_segment_new ()) {}
		internal PolyBezierSegment (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POLYBEZIERSEGMENT; }
	}

	partial class PolyLineSegment {
		public PolyLineSegment () : base (NativeMethods.poly_line_segment_new ()) {}
		internal PolyLineSegment (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POLYLINESEGMENT; }
	}

	partial class PolyQuadraticBezierSegment {
		public PolyQuadraticBezierSegment () : base (NativeMethods.poly_quadratic_bezier_segment_new ()) {}
		internal PolyQuadraticBezierSegment (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POLYQUADRATICBEZIERSEGMENT; }
	}

	partial class QuadraticBezierSegment {
		public QuadraticBezierSegment () : base (NativeMethods.quadratic_bezier_segment_new ()) {}
		internal QuadraticBezierSegment (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.QUADRATICBEZIERSEGMENT; }
	}

	partial class RadialGradientBrush {
		public RadialGradientBrush () : base (NativeMethods.radial_gradient_brush_new ()) {}
		internal RadialGradientBrush (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.RADIALGRADIENTBRUSH; }
	}

	partial class RectangleGeometry {
		public RectangleGeometry () : base (NativeMethods.rectangle_geometry_new ()) {}
		internal RectangleGeometry (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.RECTANGLEGEOMETRY; }
	}

	partial class RotateTransform {
		public RotateTransform () : base (NativeMethods.rotate_transform_new ()) {}
		internal RotateTransform (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.ROTATETRANSFORM; }
	}

	partial class ScaleTransform {
		public ScaleTransform () : base (NativeMethods.scale_transform_new ()) {}
		internal ScaleTransform (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SCALETRANSFORM; }
	}

	partial class SkewTransform {
		public SkewTransform () : base (NativeMethods.skew_transform_new ()) {}
		internal SkewTransform (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SKEWTRANSFORM; }
	}

	partial class SolidColorBrush {
		public SolidColorBrush () : base (NativeMethods.solid_color_brush_new ()) {}
		internal SolidColorBrush (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SOLIDCOLORBRUSH; }
	}

	partial class TileBrush {
		protected TileBrush () : base (NativeMethods.tile_brush_new ()) {}
		internal TileBrush (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TILEBRUSH; }
	}

	partial class TimelineMarker {
		public TimelineMarker () : base (NativeMethods.timeline_marker_new ()) {}
		internal TimelineMarker (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TIMELINEMARKER; }
	}

	partial class TimelineMarkerCollection {
		public TimelineMarkerCollection () : base (NativeMethods.timeline_marker_collection_new ()) {}
		internal TimelineMarkerCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TIMELINEMARKER_COLLECTION; }
	}

	partial class Transform {
		internal Transform () : base (NativeMethods.transform_new ()) {}
		internal Transform (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TRANSFORM; }
	}

	partial class TransformCollection {
		public TransformCollection () : base (NativeMethods.transform_collection_new ()) {}
		internal TransformCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TRANSFORM_COLLECTION; }
	}

	partial class TransformGroup {
		public TransformGroup () : base (NativeMethods.transform_group_new ()) {}
		internal TransformGroup (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TRANSFORMGROUP; }
	}

	partial class TranslateTransform {
		public TranslateTransform () : base (NativeMethods.translate_transform_new ()) {}
		internal TranslateTransform (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TRANSLATETRANSFORM; }
	}

	partial class VideoBrush {
		public VideoBrush () : base (NativeMethods.video_brush_new ()) {}
		internal VideoBrush (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.VIDEOBRUSH; }
	}
}

namespace System.Windows.Media.Animation {
	partial class BeginStoryboard {
		public BeginStoryboard () : base (NativeMethods.begin_storyboard_new ()) {}
		internal BeginStoryboard (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.BEGINSTORYBOARD; }
	}

	partial class ColorAnimation {
		public ColorAnimation () : base (NativeMethods.color_animation_new ()) {}
		internal ColorAnimation (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.COLORANIMATION; }
	}

	partial class ColorAnimationUsingKeyFrames {
		public ColorAnimationUsingKeyFrames () : base (NativeMethods.color_animation_using_key_frames_new ()) {}
		internal ColorAnimationUsingKeyFrames (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.COLORANIMATIONUSINGKEYFRAMES; }
	}

	partial class ColorKeyFrame {
		protected ColorKeyFrame () : base (NativeMethods.color_key_frame_new ()) {}
		internal ColorKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.COLORKEYFRAME; }
	}

	partial class ColorKeyFrameCollection {
		public ColorKeyFrameCollection () : base (NativeMethods.color_key_frame_collection_new ()) {}
		internal ColorKeyFrameCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.COLORKEYFRAME_COLLECTION; }
	}

	partial class DiscreteColorKeyFrame {
		public DiscreteColorKeyFrame () : base (NativeMethods.discrete_color_key_frame_new ()) {}
		internal DiscreteColorKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DISCRETECOLORKEYFRAME; }
	}

	partial class DiscreteDoubleKeyFrame {
		public DiscreteDoubleKeyFrame () : base (NativeMethods.discrete_double_key_frame_new ()) {}
		internal DiscreteDoubleKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DISCRETEDOUBLEKEYFRAME; }
	}

	partial class DiscreteObjectKeyFrame {
		public DiscreteObjectKeyFrame () : base (NativeMethods.discrete_object_key_frame_new ()) {}
		internal DiscreteObjectKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DISCRETEOBJECTKEYFRAME; }
	}

	partial class DiscretePointKeyFrame {
		public DiscretePointKeyFrame () : base (NativeMethods.discrete_point_key_frame_new ()) {}
		internal DiscretePointKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DISCRETEPOINTKEYFRAME; }
	}

	partial class DoubleAnimation {
		public DoubleAnimation () : base (NativeMethods.double_animation_new ()) {}
		internal DoubleAnimation (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DOUBLEANIMATION; }
	}

	partial class DoubleAnimationUsingKeyFrames {
		public DoubleAnimationUsingKeyFrames () : base (NativeMethods.double_animation_using_key_frames_new ()) {}
		internal DoubleAnimationUsingKeyFrames (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DOUBLEANIMATIONUSINGKEYFRAMES; }
	}

	partial class DoubleKeyFrame {
		protected DoubleKeyFrame () : base (NativeMethods.double_key_frame_new ()) {}
		internal DoubleKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DOUBLEKEYFRAME; }
	}

	partial class DoubleKeyFrameCollection {
		public DoubleKeyFrameCollection () : base (NativeMethods.double_key_frame_collection_new ()) {}
		internal DoubleKeyFrameCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.DOUBLEKEYFRAME_COLLECTION; }
	}

	partial class KeySpline {
		public KeySpline () : base (NativeMethods.key_spline_new ()) {}
		internal KeySpline (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.KEYSPLINE; }
	}

	partial class LinearColorKeyFrame {
		public LinearColorKeyFrame () : base (NativeMethods.linear_color_key_frame_new ()) {}
		internal LinearColorKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.LINEARCOLORKEYFRAME; }
	}

	partial class LinearDoubleKeyFrame {
		public LinearDoubleKeyFrame () : base (NativeMethods.linear_double_key_frame_new ()) {}
		internal LinearDoubleKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.LINEARDOUBLEKEYFRAME; }
	}

	partial class LinearPointKeyFrame {
		public LinearPointKeyFrame () : base (NativeMethods.linear_point_key_frame_new ()) {}
		internal LinearPointKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.LINEARPOINTKEYFRAME; }
	}

	partial class ObjectAnimationUsingKeyFrames {
		public ObjectAnimationUsingKeyFrames () : base (NativeMethods.object_animation_using_key_frames_new ()) {}
		internal ObjectAnimationUsingKeyFrames (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.OBJECTANIMATIONUSINGKEYFRAMES; }
	}

	partial class ObjectKeyFrame {
		protected ObjectKeyFrame () : base (NativeMethods.object_key_frame_new ()) {}
		internal ObjectKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.OBJECTKEYFRAME; }
	}

	partial class ObjectKeyFrameCollection {
		public ObjectKeyFrameCollection () : base (NativeMethods.object_key_frame_collection_new ()) {}
		internal ObjectKeyFrameCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.OBJECTKEYFRAME_COLLECTION; }
	}

	partial class PointAnimation {
		public PointAnimation () : base (NativeMethods.point_animation_new ()) {}
		internal PointAnimation (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POINTANIMATION; }
	}

	partial class PointAnimationUsingKeyFrames {
		public PointAnimationUsingKeyFrames () : base (NativeMethods.point_animation_using_key_frames_new ()) {}
		internal PointAnimationUsingKeyFrames (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POINTANIMATIONUSINGKEYFRAMES; }
	}

	partial class PointKeyFrame {
		protected PointKeyFrame () : base (NativeMethods.point_key_frame_new ()) {}
		internal PointKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POINTKEYFRAME; }
	}

	partial class PointKeyFrameCollection {
		public PointKeyFrameCollection () : base (NativeMethods.point_key_frame_collection_new ()) {}
		internal PointKeyFrameCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POINTKEYFRAME_COLLECTION; }
	}

	partial class SplineColorKeyFrame {
		public SplineColorKeyFrame () : base (NativeMethods.spline_color_key_frame_new ()) {}
		internal SplineColorKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SPLINECOLORKEYFRAME; }
	}

	partial class SplineDoubleKeyFrame {
		public SplineDoubleKeyFrame () : base (NativeMethods.spline_double_key_frame_new ()) {}
		internal SplineDoubleKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SPLINEDOUBLEKEYFRAME; }
	}

	partial class SplinePointKeyFrame {
		public SplinePointKeyFrame () : base (NativeMethods.spline_point_key_frame_new ()) {}
		internal SplinePointKeyFrame (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SPLINEPOINTKEYFRAME; }
	}

	partial class Storyboard {
		public Storyboard () : base (NativeMethods.storyboard_new ()) {}
		internal Storyboard (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.STORYBOARD; }
	}

	partial class Timeline {
		protected Timeline () : base (NativeMethods.timeline_new ()) {}
		internal Timeline (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TIMELINE; }
	}

	partial class TimelineCollection {
		public TimelineCollection () : base (NativeMethods.timeline_collection_new ()) {}
		internal TimelineCollection (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.TIMELINE_COLLECTION; }
	}
}

namespace System.Windows.Media.Imaging {
	partial class BitmapImage {
		public BitmapImage () : base (NativeMethods.bitmap_image_new ()) {}
		internal BitmapImage (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.BITMAPIMAGE; }
	}
}

namespace System.Windows.Shapes {
	partial class Ellipse {
		public Ellipse () : base (NativeMethods.ellipse_new ()) {}
		internal Ellipse (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.ELLIPSE; }
	}

	partial class Line {
		public Line () : base (NativeMethods.line_new ()) {}
		internal Line (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.LINE; }
	}

	partial class Path {
		public Path () : base (NativeMethods.path_new ()) {}
		internal Path (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.PATH; }
	}

	partial class Polygon {
		public Polygon () : base (NativeMethods.polygon_new ()) {}
		internal Polygon (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POLYGON; }
	}

	partial class Polyline {
		public Polyline () : base (NativeMethods.polyline_new ()) {}
		internal Polyline (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.POLYLINE; }
	}

	partial class Rectangle {
		public Rectangle () : base (NativeMethods.rectangle_new ()) {}
		internal Rectangle (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.RECTANGLE; }
	}

	partial class Shape {
		protected Shape () : base (NativeMethods.shape_new ()) {}
		internal Shape (IntPtr raw) : base (raw) {}
		internal override Kind GetKind () { return Kind.SHAPE; }
	}
}
