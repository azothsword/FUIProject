   M S B A M L   `   `   `  ����G  CFUIProject_A, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:FUIProject_A.Controls.SimpleControls$FUIProject_A.Controls.SimpleControls  5   	   !    FUIProject_A.OpenFileWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c$FUIProject_A_Controls_SimpleControls2clr-namespace:FUIProject_A.Controls.SimpleControls     5   	     � Title$  OpenFileWindow��5   	   $	��340��6    $	��560��6-    � 
ResizeMode$ NoResize=�69    � WindowStyle$
 None=�6O    � AllowsTransparency . ��6b   Z�  � 	Resources 5         ButtonEnterAction �� 
TargetName �� TargetProperty8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value  ButtonLeaveAction  ButtonClickAction��%;  &	        &	 �     &	 g    �� 5      $ GoBackButtonPath��6)   .��5      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6"   .g�5	        $ 0:0:0.2��6   $
 Cyan��6,   5
      5      �� 5      $ GoBackButtonPath��6)   .��5      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6"   .g�5        $ 0:0:0.2��6   $ 	#FF15AFAB��6,   5      5      �� 5      $ GoBackButtonPath��6)   .��5      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6"   .g�5        $ 0:0:0.1��6   $ 	#FFFFBC00��6,   5      5      5      	 � Triggers	 5      :� 5      
 :� RoutedEvent$
 FrameworkElement.Loaded��6   5      .��5      � $��10q�6    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 7Q�6      ShadowDepth$ 7Q�6(   .+�5      F� 4����p��!��<�p��!U �p�XU �p�X%�0:�% �� Stretch$
 Fill=�6c   ��5       �� 5!   	    �� EndPoint$ 1,0.5&�6    �� 
StartPoint$ 0,0.5&�6.   .��5"   
   �  � Color$ 	#FF1287AA��6    � Offset$ 0Q�6)   � 5#   
   $ 	#FF080B0C��6   $ 1Q�6)   5$   
   5&      F� 5(      4����p�X�݀�p�X%�0:�%�p��!�%5�p��!�݀$
 Fill=�6c   $��0,42,0,0q�6r   ��5)      �� 5*   	   $ 1,0.5&�6   $ 0,0.5&�6.   .��5+   
   � $ 	#FF0B546A��6   $ 0Q�6)   � 5,   
   $ 	#FF080B0C��6   $ 1Q�6)   5-   
   5/      F� 51      z������,!����U����Ѭa����Q�a�wB>���6@Q��,!wB>���6@��� ��6@�U ��� ��6@�%����2��@�%�D��!��<�D��!�U ���	#FF006D82$
 Fill=�6�   �� 53      $
��Left=�6   $��	20,0,0,25q�6,   $
��Wrap=�6?   $��	文件名��6S   
�������$��Bottom=�6q   $��13.333(�6�   $��Microsoft YaHei)�6�   �� 54      $
��Left=�6   $��	20,15,0,0q�6,   $
��Wrap=�6?   $��查找范围��6S   
�������$	��Top=�6r   $��13.333(�6�   $��Microsoft YaHei)�6�   � 55      -   5         �Name$ 	TitleGrid��55      $��36��6   $��6,6,6,0q�6+   $	��Top=�6<   ���	#000000006�   � 56      $��25��6   $��70,273.99,0,0q�6   $	��Top=�6/   $
��Left=�6G   $	��180��6b   .+�57      �� ���	#FF00D1FA��58   	   �� 59   
   $ 0.5,1&�6   $ 0.5,0&�6/   .��5:      � $ 	#FF002531��6   $ 0Q�6*   � 5;      $ 	#FF00495D��6   $ 1Q�6*   5<      5>   	   � 5?      $��3q�6   }�. .+�5@   	   �� -   5         ��Name$ FileNameText��5@      $��-2q�6'    �� TextWrapping$
 Wrap=�63   $9��3/FUIProject_A;component/FontFolder/#Microsoft YaHei)�6G   
������� �� SelectionBrush
 �����$��14.667(�6�   $��2,0,2,2q�6�   ��6�   Z� ��6�   Z� 6�   5A   	   5B      6   0FUIProject_A.Controls.SimpleControls.ButtonType1  5D      -   5          Name$ OpenFileButton��5D   8   6   0FUIProject_A.Controls.SimpleControls.ButtonType1   MouseLeftButtonUp$&  OpenFileButton_MouseLeftButtonUp��6�   $��30��6P   $��
260,0,0,20q�6\   $��Bottom=�6p   $	��120��6�      	ButtonStr$ 打 开��6�   $
��Left=�6�   6�     5E      -   5        $ CloseButton��5E   8   $# CloseButton_MouseLeftButtonUp��6�   $��30��6M   $��
390,0,0,20q�6Y   $��Bottom=�6m   $	��120��6�   $ 取 消��6�   $
��Left=�6�   6�   � 5F      $��20,50,20,60q�6   .+�5G      F� +����pcW p�q�p��p�q�p�����pcW ��	
������� �� StrokeStartLineCap$
 Flat=�6[   $
 Fill=�6u    �� StrokeEndLineCap$
 Flat=�6�   ���	#FF070707$��1��6�    �� StrokeMiterLimit$ 4Q�6�    �� StrokeLineJoin$ Miter=�6�   � 5H      -   5        $ FileContentGrid��5H      $��
10,5,10,25q�6&   }�. ���	#00000000.+�5I   	   � -   5         �Name$ FileDocumentItemWrapPanel��5I       � Orientation$ Vertical=�66   $
��Left=�6M   5J   	   �� 5K      -   5          ��Name$  FileContentScrollBar��5K      $��20��60   $��2,0,2,2q�6<   $��Bottom=�6M   ! �� Orientation$! 
Horizontal=�6h   " � Maximum$" 3Q�6�   # � SmallChange$# 1Q�6�   $ �� ViewportSize$$ 1Q�6�   6�   5L      8   2FUIProject_A.Controls.SimpleControls.ComboBoxType2  5M      -   5        %  Name$% DirectoryPathComboBox��5M   :   $��25��6Y   $��	80,12,0,0q�6e   $	��Top=�6x   $	��380��6�   $
��Left=�6�   ���	#000000006�   � 5N      -	   5        $ GoBackButton��5N      $��Right=�6"   $��25��6>   $��	0,12,50,0q�6J   $	��Top=�6]   $��25��6u   ���	#00000000& � Cursor$
& Hand��6K  .+�5O      F� -
   5        ' F�Name$' GoBackButtonPath��5O      F������Ks�$�Ks�$8�O�ɞ8���$8���$'���'����	#FF15AFAB$
 Fill=�6�   $��16��6�   $��8��6�   $��Center=�6�   $��Center=�6�   5P      � 5Q      -   5        $ 
GoUpButton��5Q      $��Right=�6    $��25��6<   $��	0,12,20,0q�6H   $	��Top=�6[   $��25��6s   ���	#00000000$
& Hand��6A  .+�5R      F� -   5        $' GoUpButtonPath��5R      ������#����Ѱ^[���Ѱ^[\��(LF\��X~f�HTѠ��\���o\���o�J���#��J��ϱlR���D�3Ѱ�+D�3Ѱ�+lRѰ�+��~Ѱ�+����'����'lR���	#FF15AFAB$
 Fill=�6d  $��15��6s  $��12��6~  $��Center=�6�  $��Center=�6�  5T      5V      5W      