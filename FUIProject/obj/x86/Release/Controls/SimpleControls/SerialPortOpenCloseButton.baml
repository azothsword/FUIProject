   M S B A M L   `   `   `  ����   
FUIProjectB    <FUIProject.Controls.SimpleControls.SerialPortOpenCloseButton   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     c _Microsoft.Expression.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  -     >�Name$  userControl��$��40��$��40�� � Cursor$
 Hand�� � 	Resources    ButtonOpenAction �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value	   EasingFunction.  (System.Windows.Media.Animation.CubicEase7  1System.Windows.Media.Animation.EasingFunctionBase
   
EasingMode �� KeyTime �� Value  ButtonCloseAction  ButtonDisableAction��%)
  &	        &	 Q    &	 �    �� .���� $* $(Shape.Fill).(SolidColorBrush.Color)�$	 arc��.g�  $ 0:0:0.5��$
 Lime���� $* $(Shape.Fill).(SolidColorBrush.Color)�$
 arc1��.g�  $ 0:0:0.5��$
 Lime���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse��.g�  $ 0:0:0.5��$
 Lime��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$	 arc��.\�  $ 0:0:0.5��$	 -90Q�	   $
 	EaseInOut=�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$
 arc1��.\�  $ 0:0:0.5��$	 -90Q�	   $
 	EaseInOut=�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$ ellipse��.\�  $ 0:0:0.5��$	 225Q�	   $
 	EaseInOut=��� $" (UIElement.IsHitTestVisible)�$ userControl��.p�s� $ 0�� . �� .���� $* $(Shape.Fill).(SolidColorBrush.Color)�$	 arc��.g�  $ 0:0:0.5��$ 	#FF410000���� $* $(Shape.Fill).(SolidColorBrush.Color)�$
 arc1��.g�  $ 0:0:0.5��$ 	#FF410000���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse��.g�  $ 0:0:0.5��$ 	#FF410000��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$	 arc��.\�  $ 0:0:0.5��$ 0Q�	   $
 	EaseInOut=�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$
 arc1��.\�  $ 0:0:0.5��$ 0Q�	   $
 	EaseInOut=�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$ ellipse��.\�  $ 0:0:0.5��$	 315Q�	   $
 	EaseInOut=��� $" (UIElement.IsHitTestVisible)�$ userControl��.p�s� $ 0�� . �� .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$	 arc��.\�  $ 0:0:0.5��$ 90Q�	   $
 	EaseInOut=�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$
 arc1��.\�  $ 0:0:0.5��$ 90Q�	   $
 	EaseInOut=�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$ ellipse��.\�  $ 0:0:0.5��$	 405Q�	   $
 	EaseInOut=��� $* $(Shape.Fill).(SolidColorBrush.Color)�$	 arc��.g�  $ 0:0:0.5��$ 	#FF787878���� $* $(Shape.Fill).(SolidColorBrush.Color)�$
 arc1��.g�  $ 0:0:0.5��$ 	#FF787878���� $* $(Shape.Fill).(SolidColorBrush.Color)�$ ellipse��.g�  $ 0:0:0.5��$ 	#FF787878���� $" (UIElement.IsHitTestVisible)�$ userControl��.p�s� $ 0�� .   � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.��� .+�� $
��Left=�$��0q�$��40��$��40��$	��Top=�.+�A� $��0��$��0q���
�  
� GradientOrigin$ 0.5,1.5&�.���  � Color$ 	#FF9F9F9F�� � Offset$ 0.963Q�� $ 	#FFC8C8C8��$ 0.937Q�A� $��0q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� $ 	#FFA3A3A3��� $ 	#FFF3F3F3��$ 1Q�A� ���	#FF525252$��2��$��2q�A� 
���   �$��0�����	#FF525252$��5q�%  Microsoft.Expression.Shapes.Arc  -     Name$	 arc��   ArcThickness$ 8Q�   ArcThicknessUnit$ Pixel=�   EndAngle$ 90Q����	#FF410000$��0q� �� Stretch$
 None=����	#FF525252$��0��   
StartAngle$ 0Q�$��Center=�$��Center=�$��26��$��26�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� A� ���	#FF525252$��0q�$��5��$��5�����	#FFC8C8C8$��0��$��Center=�$��Center=�  -   $
 arc1��$ 8Q�$ Pixel=�$	 270Q����	#FF410000$��0q�$
 None=����	#FF525252$��0��$	 180Q�$��Center=�$��Center=�$��26��$��26��$ 0.5,0.5&�z�V� .~��� �� �� T� A� -    A�Name$ ellipse�����	#FF525252$��0,0,0,8q�$��5��$��5�����	#FF410000$��0��$��Center=�$��Bottom=�$ 
0.5,-1.375&�z�V� .~��� �� ��  �� Angle$	 315Q�T� 