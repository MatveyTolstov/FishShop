   M S B A M L   `   `   `  ����=  9gh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ghgh  5   	       gh.Buy   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:gh     5   	   -   5          � Title$	  Buy��5	   	   $	��450��6   $	��800��6"   ���	#FF04024C.��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $
��0.1* �6   6.   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��0.2* �6   6,   �� 5      $
��0.2* �6   6,   �� 5      6   �� 5      $
��0.1* �6   6,   �� 5      $
��0.1* �6   6,   �� 5      $
��0.1* �6   6,   .+�5   
   �� -   5         ��Name$ Back_Button��5   4   $��7��6   $��3��6    $
��30px��6I   $��
Назад��6X    "  MaterialDesignRaisedDarkButton#��[  5       � ToolTip$8 2Resource name: MaterialDesignRaisedLightDarkButton��5      $
��Bold"�6>   $	��Top=�6Q   {�5   h   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�5   i   �� 5   
   -   5         ��Name$ 	Money_Box��5      $��3��6%   $��3��69   6H   �� 5   
   $��Все товары��6   $��1��6&   ���	#E5FFFFFF$
��Bold"�6J   $��18(�6\   $��Center=�6j   6�   �� 5   
   -   5        $��Money_Label��5   (   $��Товары в чеке��6   $��1��6;   $��2��6H   ���	#E5FFFFFF$
��Bold"�6o   $��18(�6�   $��Center=�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	ProductGr��5       $��2��6   ���	#FF7C7CFB	 J� OpacityMask
	 ��������	#192B0C466y     5   
   -   5        $ BuyGr��5   0   $��2��6   $��2��6    ���	#FF7C7CFB
	 ��������	#192B0C466�   �� 5    
   -   5        $ Role_Button��5    0   $��0��6   $��0��6#   $
��60px��6E   $��Покупка��6T   #��[  5!      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5"      $
��Bold"�6>   {�5    f   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5"   P   �� 5#   
   -   5        $ Save_Button��5#   0   $��3��6   $��0��6#   $
��60px��6E   $��Чеки��6T   #��[  5$      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5%      $
��Bold"�6>   {�5#   c   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5%   P   �� 5&   
   -	   5        $ Load_Button��5&   4   $��3��6   $��4��6'   $
��25px��6I   $1��+Закрыть и выгрузить чек��6X   #��[  5'      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5(      $
��Bold"�6>   {�5&   z   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5(   P   �� 5)   
   -
   5        $ Plus_Button��5)   0   $��1��6   $��2��6#   $��100px��6E   $
��30px��6T   $��+��6a   #��[  5*      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5+      $
��Bold"�6>   $
��Left=�6P   $��	4,94,0,95q�6k   {�5)   m   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5+   ~   �� 5,   
   -   5        $ Minus_Button��5,   #   $��1��6   $
��50px��69   $��-��6F   #��[  5-      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5.      $
��Bold"�6>   $��2��6k   $��Center=�6|   $��Center=�6�   $��0,50,0,0q�6�   {�5,   R   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�5.   �   5/      50      