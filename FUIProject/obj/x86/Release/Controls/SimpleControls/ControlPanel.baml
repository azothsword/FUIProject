   M S B A M L   `   `   `  ���� E  AFUIProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:FUIProject.Controls.SimpleControls"FUIProject.Controls.SimpleControls  5    /FUIProject.Controls.SimpleControls.ControlPanel   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Blocal0clr-namespace:FUIProject.Controls.SimpleControls     c _Microsoft.Expression.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  $	��260��$	��260��  � 	Resources     FileSystemToButtonPanel �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value R� KeyTime  System.Windows.Visibility   Visible R� Value   	Collapsed	 �� KeyTime
 �� Value �� KeyTime �� Value  ButtonPanelToFileSystem ! CommandButtonPageChangeAction<  6System.Windows.Media.Animation.EasingThicknessKeyFrame p� KeyTime p� Value   EasingFunction.  (System.Windows.Media.Animation.PowerEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode   Power��%�  &	        &	 �    &	 �    �� .��U� $ (UIElement.Opacity)�$ FileSystemGrid��.\�  $ 0��$ 1Q�  $ 0:0:0.2��$ 0Q�T� $ (UIElement.Visibility)�$ FileSystemGrid��..�i� $ 0��# Z i� $ 0:0:0.2��# Z U� $ (UIElement.Opacity)�$ LoadGrid��.\�  $ 0��$ 0Q�  $ 0:0:0.2��$ 0Q�  $ 0:0:0.4��$ 1Q�  $ 0:0:1.2��$ 1Q�  $ 0:0:1.4��$ 0Q�T� $ (UIElement.Visibility)�$ LoadGrid��..�i� $ 0��# Z i� $ 0:0:0.2��# Z i� $ 0:0:1.2��# Z i� $ 0:0:1.4��# Z U� $ (FrameworkElement.Width)�$ ProgressRect��.\�  $ 0��$ 0Q�  $ 0:0:0.4��$ 0Q�  $ 0:0:0.5��$ 0Q�  $ 0:0:1��$	 150Q��� $ (TextBlock.Text)�$ ProgressText��.�a� $	 0��$
 0%��a� $	 0:0:0.5��$
 0%��a� $	 0:0:0.6��$	
 20%��a� $	 0:0:0.7��$	
 40%��a� $	 0:0:0.8��$	
 60%��a� $	 0:0:0.9��$	
 80%��a� $	 0:0:1��$

 100%��U� $ (UIElement.Opacity)�$ ButtonPanelGrid��.\�  $ 0��$ 0Q�  $ 0:0:1.4��$ 0Q�  $ 0:0:1.6��$ 1Q�T� $ (UIElement.Visibility)�$ ButtonPanelGrid��..�i� $ 0��# Z i� $ 0:0:1.4��# Z �� $" (UIElement.IsHitTestVisible)�$ FileSystemGrid��.p�s� $ 0�� .  s� $ 0:0:0.2�� . �� $" (UIElement.IsHitTestVisible)�$ ButtonPanelGrid��.p�s� $ 0�� . s� $ 0:0:1.4�� . s� $ 0:0:1.6�� . �� .��U� $ (UIElement.Opacity)�$ FileSystemGrid��.\�  $ 0��$ 0Q�  $ 0:0:0.4��$ 0Q�  $ 0:0:0.6��$ 1Q�T� $ (UIElement.Visibility)�$ FileSystemGrid��..�i� $ 0��# Z i� $ 0:0:0.4��# Z U� $ (UIElement.Opacity)�$ ButtonPanelGrid��.\�  $ 0��$ 1Q�  $ 0:0:0.2��$ 0Q�T� $ (UIElement.Visibility)�$ ButtonPanelGrid��..�i� $ 0��# Z i� $ 0:0:0.2��# Z �� $" (UIElement.IsHitTestVisible)�$ ButtonPanelGrid��.p�s� $ 0�� .  s� $ 0:0:0.2�� . s� $ 0:0:0.4�� . �� .��r� $ (FrameworkElement.Margin)�$ CommandButtonGrid��.	�  $ 0:0:0.5��$ 
-214,0,0,0q�   $ 	EaseInOut=�$ 5Q� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.��� $��0q�$	��260��.+��� 
���   ����	#FFC7C7C7$��0��$��40,0,0,0q��� 
���   ����	#FFC7C7C7$��0��$
��Left=�$��80�� �� RadiusX$ 10�� �� RadiusY$ 10��F� �����e(���#@    ��Yb    �~,    ���2    ���2 I�~, I��Yb I�e(���#@ I�.�*��@ I�g�����:KW�   d=����KW�   d=�� �g����@�Μ��@.�*��@e(���#@	 �� Stretch$
 Fill=�
���   �$��0������  �� EndPoint$ 1,0.5&� �� 
StartPoint$ 0,0.5&�.���  � Color$ 	#FFA5A5A5�� � Offset$ 0Q�� $ 	#00C8C8C8��$
 0.03Q�F� �����e(���#@    ��Yb    �~,    ���2    ���2 I�~, I��Yb I�e(���#@ I�.�*��@ I�g�����:KW�   d=����KW�   d=�� �g����@�Μ��@.�*��@e(���#@	$
 Fill=�
���   �$��0������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF606060��$ 0Q�� $ 	#00C8C8C8��$ 0.052Q�F� �����e(���#@    ��Yb    �~,    ���2    ���2 I�~, I��Yb I�e(���#@ I�.�*��@ I�g�����:KW�   d=����KW�   d=�� �g����@�Μ��@.�*��@e(���#@	$
 Fill=�
���   �$��0������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFDADADA��$ 1Q�� $ 	#00C8C8C8��$ 0.948Q�� $��15q�.+��� 
���   �$��0�����	#FF126695�� 
���   �$��0������ $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#00858585��$ 0.033Q��� 
���   �$��0������ $ 1,0.5&�$ 0,0.5&�.��� $ 	#FF121212��$ 0Q�� $ 	#00606060��$ 0.026Q��� 
���   �$��0������ $ 1,0.5&�$ 0,0.5&�.��� $ 	#FF2F2F2F��$ 1Q�� $ 	#00787878��$ 0.989Q��� 
���   �$��0������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF2F2F2F��$ 1Q�� $ 	#00787878��$ 0.989Q�� $	��8,5q�.+�� -    �Name$ FileSystemGrid�����	#00000000}�. .+��� -    ��Name$ FileSystemStackPanel��$��0q�$	��Top=�.+�=   7FUIProject.Controls.SimpleControls.ControlPanelFileItem     ItemTextStr$ <...>Go Back��  $ 
Document_1��  $ 
Document_2��  $ 
Document_3��  $ 
File_1.ini��   FileDocumentType$
 File=��� $��1��$��0,0,0,25q�
���   �$��0��$��Bottom=�
�������$y�	Collapsed=�� $��Right=�$	��0,2q�$��4��$y�	Collapsed=�.+��� ���	#7FF4F4F5
���   �$��0��$ 2��$ 2��$	��Top=�$��30��� -   $ LoadGrid�� J� Opacity$ 0Q�$y�	Collapsed=�.+��� $��Center=�$��0,80,0,0q�$
��Wrap=�$��
Loading...��$��OCR A Extended)�$	��Top=�
�������$��16(��� -     ��Name$  ProgressRect��
�������$��
10,110,0,0q�
���   �$��0��$
��Left=�$��0��$��6��$	��Top=��� -   ! ��Name$! ProgressText��$��Right=�$��
0,105,10,0q�$
��Wrap=�$��0%��$��OCR A Extended)�
�������$��13.333(�$	��Top=��� $��	8,108,0,0q�
�������$
��Left=�$	��154��$��10��$	��Top=�� -   $ ButtonPanelGrid��$ 0Q�$y�	Collapsed=�.+��� $��1��$��0,0,0,25q�
���   �$��0��$��Bottom=�
�������� $��0,0,0,39q�}�. .+�� -   $ CommandButtonGrid��}�. $
��Left=�$��0q�G   AFUIProject.Controls.SimpleControls.ControlPanelCommandToolsButton  -   "  Name$" ButtonPanelBeforeButton��G   AFUIProject.Controls.SimpleControls.ControlPanelCommandToolsButton#   MouseLeftButtonDown$1# +ButtonPanelBeforeButton_MouseLeftButtonDown��$��20��$��Bottom=�$��40��$
��Left=�$   ButtonTextStr$
$ Befo��  -	   $" ButtonPanelNextButton��$/# )ButtonPanelNextButton_MouseLeftButtonDown��$��20��$��Bottom=�$��40��$
��Left=�$
$ Next��$��45,0,0,0q�  -
   $#" ButtonPanelToFileSystemButton��$7# 1ButtonPanelToFileSystemButton_MouseLeftButtonDown��$��20��$��Bottom=�$��40��$��Right=�$
$ Back��$��0q�F� +����        Ѥ�o
    ђ�f����    ���	���	#0CFFFFFF$��0,0,54.905,0q�$
 Fill=�
���   �$��0��% J� IsHitTestVisible% .  