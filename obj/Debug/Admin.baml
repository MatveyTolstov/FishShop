   M S B A M L   `   `   `  ����=  9gh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ghgh  5   	       gh.Admin   5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:gh     5   	     � Title$  Admin��5	   	   $	��450��6   $	��800��6$   ���	#FF04024C.��5
      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      6!   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $
��0.2* �6    60   �� 5      6"   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ RolesGr��5      $��1��6(   ���	#FF7C7CFB J� OpacityMask
 ��������	#192B0C465      � 5      $��0��6    5      �� 5      6)   �� 5      6)   .+�5      �� -   5         ��Name$ Role_Button��5   +   $��0��6   $
��60px��6@   $��Роли��6O    "  MaterialDesignRaisedDarkButton#��[  5       � ToolTip$8 2Resource name: MaterialDesignRaisedLightDarkButton��5      $
��Bold"�6I   {�5   ^   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�5   [   �� 5      -   5        $ Employ_Button��5      $��1��61   $
��60px��6A   $��Сотрудники��6P   #��[  5       $8 2Resource name: MaterialDesignRaisedLightDarkButton��5!      $
��Bold"�6>   {�5   e   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5!   P   5"      5#      � 5$   
   $��1��6    5%      �� 5&      $
��0.8* �6    60   �� 5'      6"   �� 5(      6"   �� 5)      6"   �� 5*      6"   �� 5+      6"   �� 5,      $
��0.5* �6    60   �� 5-      $
��0.5* �6    60   .+�5/      �� -   5        $ Back_Button��5/   $   $��7��6   $
��30px��69   $��
Назад��6H   #��[  50      $8 2Resource name: MaterialDesignRaisedLightDarkButton��51      $
��Bold"�6>   $	��Top=�6Q   {�5/   X   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�51   i   �� 52      -   5        $ Button_Auth��52      $0��*Данные для авторизации��6*   $��60��6K   #��[  54      $8 2Resource name: MaterialDesignRaisedLightDarkButton��55      $
��Bold"�6@   {�53      �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�55   R   �� 56      $.��(Данные для заполнения��6   $��1��65   $��Center=�6B   $��Center=�6_   $��20(�6z   
�������$
��Bold"�6�   �� 57      -   5        	 ��Name$	 FirstText_Box��57      $��2��6-   
�������
 �� 
CaretBrush
 �	#FF330F72$
��Bold"�6d   $��16(�6v   $��Center=�6�   $��	20,0,20,0q�6�   G� 58      -   5         G�Name$ 	FirstPswd��58      $��3��6-   $��	20,0,20,0q�6:   $
��Bold"�6M   $��16(�6_    G� 
CaretBrush �	#FF330F72
�������6�   �� 59      -   5        $	 SecondText_Box��59      $��3��6.   
�������
 �	#FF330F72$
��Bold"�6e   $��16(�6w   $��Center=�6�   $��	20,0,20,0q�6�   �� 5:      -	   5        $	 ThirdText_Box��5:      $��4��6.   
�������
 �	#FF330F72$
��Bold"�6e   $��16(�6w   $��Center=�6�   $��	20,0,20,0q�6�   �� 5;      -
   5        $��Fourth_Combobox��5;      $��5��6.   6@   � 5<      $��6��6    5=      �� 5>      6)   �� 5?      6)   �� 5@      6)   .+�5C      �� -   5        $ Create_Button��5C      $��Добавить��60   #��[  5D      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5E      $��12(�6@   $��2��6j   $��0,1,89,1q�6~   {�5C   D   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5E   ~   �� 5F      -   5        $ Update_Button��5F      $��Изменить��60   $��1��6C   #��[  5G      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5H      $��12(�6@   {�5F   S   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5H   l   �� 5I      -   5        $ Delete_Button��5I      $��Удалить��60   $��2��6B   #��[  5J      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5K      $��12(�6@   {�5I   R   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5K   l   5L      5M      5N      5O      