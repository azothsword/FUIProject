   M S B A M L   `   `   `  ����  
FUIProject=    7FUIProject.Controls.SimpleControls.ControlPanelFileItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        $	��214��5   7   $��20��6C     � 	Resources  5         MouseEnterAction �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value  MouseLeaveAction��%|  &	        &	 �     �� 5	      .��5
      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $ MouseEnterRect��6c   .g�5        $ 0:0:0.2��6   $ 	#FF1588C8��6,   5      5      �� 5      .��5      �� $* $(Shape.Fill).(SolidColorBrush.Color)�6"   $ MouseEnterRect��6c   .g�5        $ 0:0:0.2��6   $ 	#001588C8��6,   5      5      5       � Triggers 5      :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   5      .��5      � .+�5      �� -   5         ��Name$ MouseEnterRect��5      
���   �$��0��68   ���	#001588C8$��0q�6]   � 5      -   5         �Name$ FileGrid��5      $
��Left=�6   $��0q�69   $��20��6D   $��20��6O   $	��Top=�6[   $y�	Collapsed=�6s   .+�5      F� �����M�k   @�ޙ �M�k   @� � р�� � � р�� �ޙ 0M�k   @���+ @M�k   @���+"@Q��� ���+"@Q��� ���+ @0M�k   @cqIV@M�k   @cqIV@Q��� cqIV@Q��� cqIV@0M�k   @cqIV@M�k   @cqIV@Q��� cqIV@Q��� cqIV@0M�k   @��>� @M�k   @+�#�@Q��� +�#�@Q��� ��>� @�5�5  �?    ��ا     �F�      � ��*�]��? � �������?� � @]� � � ��� F� ��� �ا ��� �5�5  �?��� ����^��?��� ��  p>��� @]� Q    �������?��  p>��*�]��?���^��?5�5  �?	
�������$
��Left=�6T  $��14��6o  $��2,0,0,0q�6{  	 �� Stretch$
	 Fill=�6�  
���   �$��0��6�  $��Center=�6�  $��12��6�  5      � 5      -   5        $ DocumentGrid��5      $
��Left=�6"   $��0q�6=   $��20��6H   $��20��6S   $	��Top=�6_   .+�5       F� ����p    YJ���@Q`�� YJ���@�7��  � ����E�*@ � �$H���(@    ����h�@    ���h�@e(����?Q�l	e(����?��l	 � ћk	 � Q��� �����@$H���(@�����@$H���(@e(����?	
�������$��12��6�   $��0,4,0,0q�6   $
	 Fill=�6  
���   �$��0��6/  $	��Top=�6C  $��17��6[  $
��Left=�6f  5!      � 5"      $��20,0,0,0q�6   $��20��6   $	��Top=�6*   .+�5#      �� -   5        
 ��Name$
 ItemText��5#      $
��Left=�6$   $��0q�6?   $
��Wrap=�6J   $��
Document_1��6^   $��OCR A Extended)�6p   $��Center=�6�   
�������$��10.667(�6�   5$      5&      5'      