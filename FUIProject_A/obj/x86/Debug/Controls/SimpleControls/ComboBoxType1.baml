   M S B A M L   `   `   `  ����  FUIProject_A8    2FUIProject_A.Controls.SimpleControls.ComboBoxType1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  userControl��5      $	��100��5   3   $��25��6?    � 	Resources 5         ComboOpenAction �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode  ComboCloseAction  MouseEnterAction8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime	 �� Value  MouseLeaveAction  MouseLeftButtonDownAction��%�  &	        &	 �     &	 v    &	 �    &	 �    �� 5      .��5	      U� $ (FrameworkElement.Height)�6#   $ userControl��6Y   .\�5
        $ 0:0:0.2��6   $	 125Q�6-    5        5      $ EaseOut=�6   5      5      5      �� 5      .��5      U� $ (FrameworkElement.Height)�6#   $ userControl��6Y   .\�5        $ 0:0:0.3��6   $ 25Q�6-   5      5      �� 5      .��5      �� $H B(Shape.Fill).(GradientBrush.GradientStops)[1].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5        $ 0:0:0.2��6   $	 	#FF0389A7��6,   5      �� 5      $H B(Shape.Fill).(GradientBrush.GradientStops)[0].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5        $ 0:0:0.2��6   $	 	#FF084856��6,   5      �� 5      $, &(Shape.Stroke).(SolidColorBrush.Color)�6"   $ 	rectangle��6e   .g�5        $ 0:0:0.2��6   $	 	#FF00D1FA��6,   5      5       �� 5!      .��5"      �� $H B(Shape.Fill).(GradientBrush.GradientStops)[1].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5#        $ 0:0:0.2��6   $	 	#FF00495D��6,   5$      �� 5%      $H B(Shape.Fill).(GradientBrush.GradientStops)[0].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5&        $ 0:0:0.2��6   $	 	#FF002531��6,   5'      �� 5(      $, &(Shape.Stroke).(SolidColorBrush.Color)�6"   $ 	rectangle��6e   .g�5)        $ 0:0:0.2��6   $	 	#FF00D1FA��6,   5*      5+      �� 5,      .��5-      �� $H B(Shape.Fill).(GradientBrush.GradientStops)[1].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�5.        $ 0:0:0.2��6   $	 	#FFF07D00��6,   5/      �� 50      $H B(Shape.Fill).(GradientBrush.GradientStops)[0].(GradientStop.Color)�6"   $ 	rectangle��6�   .g�51        $ 0:0:0.2��6   $	 	#FF9B5101��6,   52      �� 53      $, &(Shape.Stroke).(SolidColorBrush.Color)�6"   $ 	rectangle��6e   .g�54        $ 0:0:0.2��6   $	 	#FFFCC900��6,   55      56      57      
 � Triggers
 58      :� 59       :� RoutedEvent$ FrameworkElement.Loaded��6   5:      .��5<      � $��0q�6   .+�5=      �� ���	#FF00D1FA��5>      �� 5?       �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6+   .��5@      �  � Color$ 	#FF002531��6    � Offset$ 0Q�6&   � 5A      $ 	#FF00495D��6   $ 1Q�6&   5B      5D      � 5E      -   5         �Name$ OpenOrCloseGrid��5E   	   $��19��6"   $��3,3,3,0q�6.   $	��Top=�6?   ���	#00000000 � Cursor$
 Hand��6�   .+�5F      � $��Right=�6
   $��19��6&   $
 Hand��61   .+�5G      �� -   5         ��Name$ 	rectangle��5G      ���	#FF00D1FA��5H      �� 5I      $ 0.5,1&�6   $ 0.5,0&�6-   .��5J   	   � $ 	#FF002531��6   $ 1Q�6(   � 5K   	   $ 	#FF00495D��6   5L   	   5N      F� 5O      -   5         F�Name$ OpenPath��5O      1���������@    ������@ z �Z^�f})� z 	
�������$��Center=�6_   $��8��6|   $��0q�6�    J� RenderTransformOrigin$ 0.500000000185463,0.5&�6�    �� Stretch$
 Fill=�6�   ���	#FF00D1FA$��0��6�   $��Center=�6�   $��8��6  z�5P      V� 5Q      .~�5R   	   �� �� 5S   	   �� 5T   	    �� Angle$	 180Q�6   T� 5U   	   5V   	   5X      F� 5Y      -   5        $ 	ClosePath��5Y      1���������@    ������@ z �Z^�f})� z 	
�������$��Center=�6`   $��8��6}   $��0q�6�   $ 0.500000000185463,0.5&�6�   $
 Fill=�6�   ���	#FF00D1FA$��0��6�   $��Center=�6�   $��8��6  $y�	Collapsed=�6  5Z      � 5[      $��0,0,22,0q�6
   .+�5\      �� -   5         ��Name$ 
SelectText��5\      $��Center=�6$   $��0q�6A   $
��Wrap=�6L   
�������$��Center=�6s   $��14.667(�6�   $��Microsoft Sans Serif)�6�   5]      5^      �� 5_      -   5         ��Name$ ContentStackPanel��5_      $��	3,25,25,0q�6*    �� Orientation$ Vertical=�6=   $	��Top=�6T   .+�5`      � $��20��6
   .+�5a      �� $��Center=�6   $
��Wrap=�6-   $
��9600��6A   
�������$��Center=�6`   $��14.667(�6{   $��Microsoft Sans Serif)�6�   5b      � 5c      $��20��6
   .+�5d      �� $��Center=�6   $��0q�6-   $
��Wrap=�68   $
��9600��6L   
�������$��Center=�6k   $��14.667(�6�   $��Microsoft Sans Serif)�6�   5e      � 5f      $��20��6
   .+�5g      �� $��Center=�6   $��0q�6-   $
��Wrap=�68   $
��9600��6L   
�������$��Center=�6k   $��14.667(�6�   $��Microsoft Sans Serif)�6�   5h      � 5i      $��20��6
   .+�5j      �� $��Center=�6   $��0q�6-   $
��Wrap=�68   $
��9600��6L   
�������$��Center=�6k   $��14.667(�6�   $��Microsoft Sans Serif)�6�   5k      � 5l      $��20��6
   .+�5m      �� $��Center=�6   $��0q�6-   $
��Wrap=�68   $
��9600��6L   
�������$��Center=�6k   $��14.667(�6�   $��Microsoft Sans Serif)�6�   5n      5o      5p      5q      