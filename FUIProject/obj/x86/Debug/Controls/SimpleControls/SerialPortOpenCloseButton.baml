   M S B A M L   `   `   `  ����  
FUIProjectB    <FUIProject.Controls.SimpleControls.SerialPortOpenCloseButton   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _Microsoft.Expression.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5      -   5          >�Name$  userControl��5   N   $��40��5   7   $��40��6B    � Cursor$
 Hand��6N    � 	Resources 5	         ButtonOpenAction �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value	   EasingFunction.  (System.Windows.Media.Animation.CubicEase7  1System.Windows.Media.Animation.EasingFunctionBase
   
EasingMode �� KeyTime �� Value  ButtonCloseAction  ButtonDisableAction��%Z  &	        &	     &	 #
    �� 5
      .��5      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $	 arc��6c   .g�5        $ 0:0:0.5��6   $
 Lime��6,   5      �� 5      $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $
 arc1��6c   .g�5        $ 0:0:0.5��6   $
 Lime��6,   5      �� 5      $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $ ellipse��6c   .g�5        $ 0:0:0.5��6   $
 Lime��6,   5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $	 arc��6�   .\�5        $ 0:0:0.5��6   $	 -90Q�6-   	 5        5      $
 	EaseInOut=�6   5      5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $
 arc1��6�   .\�5        $ 0:0:0.5��6   $	 -90Q�6-   	 5        5      $
 	EaseInOut=�6   5       5!      U� 5"      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $ ellipse��6�   .\�5#        $ 0:0:0.5��6   $	 225Q�6-   	 5$        5%      $
 	EaseInOut=�6   5'      5(      �� 5)      $" (UIElement.IsHitTestVisible)�6$   $ userControl��6]   .p�5*      s� $ 0��6    . 6*   5+      5,      �� 5-      .��5.      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $	 arc��6c   .g�5/        $ 0:0:0.5��6   $ 	#FF410000��6,   50      �� 51      $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $
 arc1��6c   .g�52        $ 0:0:0.5��6   $ 	#FF410000��6,   53      �� 54      $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $ ellipse��6c   .g�55        $ 0:0:0.5��6   $ 	#FF410000��6,   56      U� 57      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $	 arc��6�   .\�58        $ 0:0:0.5��6   $ 0Q�6-   	 59        5:      $
 	EaseInOut=�6   5<      5=      U� 5>      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $
 arc1��6�   .\�5?        $ 0:0:0.5��6   $ 0Q�6-   	 5@        5A      $
 	EaseInOut=�6   5C      5D      U� 5E      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $ ellipse��6�   .\�5F        $ 0:0:0.5��6   $	 315Q�6-   	 5G        5H      $
 	EaseInOut=�6   5J      5K      �� 5L      $" (UIElement.IsHitTestVisible)�6$   $ userControl��6]   .p�5M      s� $ 0��6    . 6*   5N      5O      �� 5P      .��5Q      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $	 arc��6�   .\�5R        $ 0:0:0.5��6   $ 90Q�6-   	 5S        5T      $
 	EaseInOut=�6   5V      5W      U� 5X      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $
 arc1��6�   .\�5Y        $ 0:0:0.5��6   $ 90Q�6-   	 5Z        5[      $
 	EaseInOut=�6   5]      5^      U� 5_      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $ ellipse��6�   .\�5`        $ 0:0:0.5��6   $	 405Q�6-   	 5a        5b      $
 	EaseInOut=�6   5d      5e      �� 5f      $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $	 arc��6c   .g�5g        $ 0:0:0.5��6   $ 	#FF787878��6,   5h      �� 5i      $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $
 arc1��6c   .g�5j        $ 0:0:0.5��6   $ 	#FF787878��6,   5k      �� 5l      $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $ ellipse��6c   .g�5m        $ 0:0:0.5��6   $ 	#FF787878��6,   5n      �� 5o      $" (UIElement.IsHitTestVisible)�6$   $ userControl��6]   .p�5p      s� $ 0��6    .  6*   5q      5r      5s       � Triggers 5t      :� 5u       :� RoutedEvent$ FrameworkElement.Loaded��6   5v      .��5x      � .+�5z      � $
��Left=�6   $��0q�6'   $��40��62   $��40��6=   $	��Top=�6I   .+�5{      A� $��0��6   $��0q�6$   ��5|   	   
� 5}   
    
� GradientOrigin$ 0.5,1.5&�6   .��5~      �  � Color$ 	#FF9F9F9F��6    � Offset$ 0.963Q�6*   � 5      $ 	#FFC8C8C8��6   $ 0.937Q�6*   5�      5�   	   A� 5�      $��0q�6   ��5�   	   �� 5�   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5�      � $ 	#FFA3A3A3��6   � 5�      $ 	#FFF3F3F3��6   $ 1Q�6*   5�      5�   	   A� 5�      ���	#FF525252$��2��6#   $��2q�67   A� 5�      
���   �$��0��6   ���	#FF525252$��5q�6D   %  Microsoft.Expression.Shapes.Arc  5�      -   5          Name$	 arc��5�         ArcThickness$ 8Q�6      ArcThicknessUnit$ Pixel=�6-      EndAngle$ 90Q�6F   ���	#FF410000$��0q�6e    �� Stretch$
 None=�6p   ���	#FF525252$��0��6�      
StartAngle$ 0Q�6�   $��Center=�6�   $��Center=�6�   $��26��6�   $��26��6�    J� RenderTransformOrigin$ 0.5,0.5&�6  z�5�   	   V� 5�   
   .~�5�      �� �� 5�      �� 5�      T� 5�      5�      5�   	   A� 5�      ���	#FF525252$��0q�6#   $��5��6.   $��5��68   ���	#FFC8C8C8$��0��6T   $��Center=�6h   $��Center=�6�     5�      -   5        $
 arc1��5�      $ 8Q�6   $ Pixel=�6.   $	 270Q�6G   ���	#FF410000$��0q�6g   $
 None=�6r   ���	#FF525252$��0��6�   $	 180Q�6�   $��Center=�6�   $��Center=�6�   $��26��6�   $��26��6�   $ 0.5,0.5&�6  z�5�   	   V� 5�   
   .~�5�      �� �� 5�      �� 5�      T� 5�      5�      5�   	   A� 5�      -   5         A�Name$ ellipse��5�      ���	#FF525252$��0,0,0,8q�64   $��5��6E   $��5��6O   ���	#FF410000$��0��6k   $��Center=�6   $��Bottom=�6�   $ 
0.5,-1.375&�6�   z�5�   	   V� 5�   
   .~�5�      �� �� 5�      �� 5�       �� Angle$	 315Q�6   T� 5�      5�      5�   	   5�      5�      5�      