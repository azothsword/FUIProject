   M S B A M L   `   `   `  ����  FUIProject_A8    2FUIProject_A.Controls.SimpleControls.ComboBoxType2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  userControl��5      $	��100��5   7   $��25��6C    � 	Resources 5         ComboOpenAction �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode  ComboCloseAction  MouseEnterAction8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime	 �� Value  MouseLeaveAction  MouseLeftButtonDownAction��%�  &	        &	 �     &	 v    &	 �    &	 �    �� 5	      .��5
      U� $ (FrameworkElement.Height)�6#   $ userControl��6Y   .\�5        $ 0:0:0.2��6   $	 125Q�6-    5        5      $ EaseOut=�6   5      5      5      �� 5      .��5      U� $ (FrameworkElement.Height)�6#   $ userControl��6Y   .\�5        $ 0:0:0.3��6   $ 25Q�6-   5      5      �� 5      .��5      �� $H B(Shape.Fill).(GradientBrush.GradientStops)[1].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5        $ 0:0:0.2��6   $	 	#FF0389A7��6,   5      �� 5      $H B(Shape.Fill).(GradientBrush.GradientStops)[0].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5        $ 0:0:0.2��6   $	 	#FF084856��6,   5      �� 5      $, &(Shape.Stroke).(SolidColorBrush.Color)�6"   $ 	rectangle��6e   .g�5        $ 0:0:0.2��6   $	 	#FF00D1FA��6,   5       5!      �� 5"      .��5#      �� $H B(Shape.Fill).(GradientBrush.GradientStops)[1].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5$        $ 0:0:0.2��6   $	 	#FF00495D��6,   5%      �� 5&      $H B(Shape.Fill).(GradientBrush.GradientStops)[0].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5'        $ 0:0:0.2��6   $	 	#FF002531��6,   5(      �� 5)      $, &(Shape.Stroke).(SolidColorBrush.Color)�6"   $ 	rectangle��6e   .g�5*        $ 0:0:0.2��6   $	 	#FF00D1FA��6,   5+      5,      �� 5-      .��5.      �� $H B(Shape.Fill).(GradientBrush.GradientStops)[1].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5/        $ 0:0:0.2��6   $	 	#FFF07D00��6,   50      �� 51      $H B(Shape.Fill).(GradientBrush.GradientStops)[0].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�52        $ 0:0:0.2��6   $	 	#FF9B5101��6,   53      �� 54      $, &(Shape.Stroke).(SolidColorBrush.Color)�6"   $ 	rectangle��6e   .g�55        $ 0:0:0.2��6   $	 	#FFFCC900��6,   56      57      58      
 � Triggers
 59      :� 5:       :� RoutedEvent$ FrameworkElement.Loaded��6   5;      .��5=      � $��0q�6   .+�5>      �� ���	#FF00D1FA��5?      �� 5@       �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6+   .��5A      �  � Color$ 	#FF002531��6    � Offset$ 0Q�6&   � 5B      $ 	#FF00495D��6   $ 1Q�6&   5C      5E      � 5F      -   5         �Name$ OpenOrCloseGrid��5F   	   $��19��6"   $��3,3,3,0q�6.   $	��Top=�6?   ���	#00000000 � Cursor$
 Hand��6�   .+�5G      � $��Right=�6
   $��19��6&   $
 Hand��61   .+�5H      �� -   5         ��Name$ 	rectangle��5H      ���	#FF00D1FA��5I      �� 5J      $ 0.5,1&�6   $ 0.5,0&�6-   .��5K   	   � $ 	#FF002531��6   $ 1Q�6(   � 5L   	   $ 	#FF00495D��6   5M   	   5O      F� 5P      -   5         F�Name$ OpenPath��5P      1���������@    ������@ z �Z^�f})� z 	
�������$��Center=�6_   $��8��6|   $��0q�6�    J� RenderTransformOrigin$ 0.500000000185463,0.5&�6�    �� Stretch$
 Fill=�6�   ���	#FF00D1FA$��0��6�   $��Center=�6�   $��8��6  z�5Q      V� 5R      .~�5S   	   �� �� 5T   	   �� 5U   	    �� Angle$	 180Q�6   T� 5V   	   5W   	   5Y      F� 5Z      -   5        $ 	ClosePath��5Z      1���������@    ������@ z �Z^�f})� z 	
�������$��Center=�6`   $��8��6}   $��0q�6�   $ 0.500000000185463,0.5&�6�   $
 Fill=�6�   ���	#FF00D1FA$��0��6�   $��Center=�6�   $��8��6  $y�	Collapsed=�6  5[      � 5\      $��0,0,22,0q�6
   .+�5]      �� -   5         ��Name$ 
SelectText��5]      $
��Left=�6$   $��0q�6?   $
��Wrap=�6J   
�������$��Center=�6q   $��Microsoft Sans Serif)�6�   5^      5_      �� 5`      -   5         ��Name$ ContentStackPanel��5`      $��	3,25,25,0q�6*    �� Orientation$ Vertical=�6=   $	��Top=�6T   .+�5a      � $��20��6
   .+�5b      �� $��Center=�6   $
��Wrap=�6-   $
��9600��6A   
�������$��Center=�6`   $��14.667(�6{   $��Microsoft Sans Serif)�6�   5c      � 5d      $��20��6
   .+�5e      �� $��Center=�6   $��0q�6-   $
��Wrap=�68   $
��9600��6L   
�������$��Center=�6k   $��14.667(�6�   $��Microsoft Sans Serif)�6�   5f      � 5g      $��20��6
   .+�5h      �� $��Center=�6   $��0q�6-   $
��Wrap=�68   $
��9600��6L   
�������$��Center=�6k   $��14.667(�6�   $��Microsoft Sans Serif)�6�   5i      � 5j      $��20��6
   .+�5k      �� $��Center=�6   $��0q�6-   $
��Wrap=�68   $
��9600��6L   
�������$��Center=�6k   $��14.667(�6�   $��Microsoft Sans Serif)�6�   5l      � 5m      $��20��6
   .+�5n      �� $��Center=�6   $��0q�6-   $
��Wrap=�68   $
��9600��6L   
�������$��Center=�6k   $��14.667(�6�   $��Microsoft Sans Serif)�6�   5o      5p      5q      5r      