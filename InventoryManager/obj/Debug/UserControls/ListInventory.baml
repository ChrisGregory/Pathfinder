   M S B A M L   `   `   `  ����  InventoryManager-    'InventoryManager.UserControls.Inventory   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � $��5q�6   
�������  � RowDefinitions  5	   
   �� 5
      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��1* �6   �� 5      $��30 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   .+�5      �� $��Allister��6   �� 5      $��Level 6��6   �� 5      $��Slyph��6   �� 5      $��Techslinger��6   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5      �� $��Health��6   $��Center=�6%   � 5       � Minimum$	 -10Q�6    � Maximum$ 35Q�6(    � Value$ 20Q�65   $��10��6@   $	��200��6L   5      �� 5   
   $��2��6   $��Center=�6"   $��Center=�6?   $��5q�6Z   .+�5      �� $��Add Item��6   5      �� 5   
   $��3��6   $��10q�6   $
��Auto=�6+   $��Disabled=�6[   
���������5      �� 5      .R�5       � 
�������$��5q�6-   $��85��68    � ColumnDefinitions 5!      �� 5"      $��1* �6/   �� 5#      $��3* �6/   .+�5%      ��  J� Effect 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'   "   ._�5)      �� $7��1/InventoryManager;component/Images/potato (3).png��6$   $��Center=�5*   $   $��Center=�5+   $   5,      � 5-      $��1��6     5.      �� 5/   "   $��1* �60   �� 50   "   $��1* �60   .+�52      �� $��Potato��53      
�������$
��Bold)�55      $��18(�56      $��Center=�57      $��Center=�58      �� 59      $��Center=�6)   $ 
Horizontal=�6F   $��1��6_   .+�5:   "   �� $��Weight: 1 lb.��5;      
�������$��16(�5=      $��Center=�5>      $��Center=�5?      �� 5@   "   $��1��5A      $��Value: 2��5B      
�������$��16(�5D      $��Center=�5E      $��Center=�5F      �� 5G   "    5H   &     5I   *   ._�5K   &   �� $9��3/InventoryManager;component/Images/Coins/Copper.png��6,   $��20��6i   $��20��6u   5L   #   5M      5N      5O      5P      5R      �� 5S   
   $��4��6   $ 
Horizontal=�6"   $��0,0,0,5q�6;   $��Center=�6L   $��Center=�6g   .+�5T      �� $��Wealth:��6   �� 5U      $��0��6   �� 5V      $9��3/InventoryManager;component/Images/Coins/Copper.png��6   $��20��6Q   $��20��6]   �� 5W      $��0��6   �� 5X      $9��3/InventoryManager;component/Images/Coins/Silver.png��6   $��20��6Q   $��20��6]   �� 5Y      $��0��6   �� 5Z      $7��1/InventoryManager;component/Images/Coins/Gold.png��6   $��20��6O   $��20��6[   �� 5[      $��0��6   �� 5\      $;��5/InventoryManager;component/Images/Coins/Platinum.png��6   $��20��6S   $��20��6_   5]      5^      5_      