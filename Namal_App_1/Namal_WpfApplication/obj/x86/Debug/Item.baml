   M S B A M L   `   `   `  ����  Namal_WpfApplication    Namal_WpfApplication.Item   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$
 Item��5   	   $	��400��6   $	��700��6#   .��5      � ���	#FF16184D � ColumnDefinitions 5   
   �� 5
      $
��116* �6   6.   �� 5      $
��116* �6   6.   �� 5      $
��116* �6   6.   �� 5      $
��115* �6   6.   �� 5      $
��116* �6   6.   �� 5      $	��97* �6   6-   �� 5      $	��18* �6    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5       6   .+�5%   
   �� $��Manage Item Details��6   $��1��6.   $
��Left=�6>   $��
73,-11,0,0q�6Y   $	��Top=�6m   $��4��6�   $	��361��6�   $��28(�6�   $��Oblique$�6�   $��2��6�   �� 5'   
   -   5         ��Name$ b_home��5'      $
��HOME��6!   $
��Bold"�60   $
��Left=�6B   $��	24,10,0,0q�6]   $��75��6p   $��21��6�   $	��Top=�6�   �� 5(   
   -   5        $
 b_ai��5(      $��Add Item��6    $��1��63   $
��Left=�6C   $��2��6^   $��Bottom=�6k   $	��106��6�   $��10,0,0,8q�6�   6�   �� 5)   
   -   5        $
 b_ui��5)      $��Update Item��6    $��2��66   $
��Left=�6F   $��10,3,0,0q�6a   $��2��6s   $	��Top=�6�   $	��106��6�   $��20��6�   6�   �� 5*   
   -   5        $
 b_di��5*      $��Delete Item��6    $��3��66   $
��Left=�6F   $��10,3,0,0q�6a   $��2��6s   $	��Top=�6�   $	��105��6�   $��20��6�   6�   �� 5+   
   -   5        $ b_clear��5+      $��CLEAR��6#   $��3��63   $��Right=�6C   $��	0,0,14,11q�6_   $��10��6r   $��91��6�   $��20��6�   $��Bottom=�6�   �� 5-   
   -   5        $ iadd_b��5-      $	��ADD��6"   $��2��60   $
��Left=�6@   $��10,1,0,0q�6[   $��10��6m   $	��Top=�6{   $��75��6�   $y�Visible=�6�   6�   �� 5.   
   -   5        $ iupdt_b��5.      $��UPDATE��6#   $��2��64   $
��Left=�6D   $��10,1,0,0q�6_   $��10��6q   $	��Top=�6   $��75��6�   $y�	Collapsed=�6�   6�   �� 5/   
   -   5        $ idelt_b��5/      $��DELETE��6#   $��2��64   $
��Left=�6D   $��10,1,0,0q�6_   $��10��6q   $	��Top=�6   $��75��6�   $y�	Collapsed=�6�   6�   �� 51   
   -	   5        $ b_cancle��51      $��CANCLE��6$   $��4��65   $
��Left=�6E   $��31,0,0,0q�6`   $��10��6r   $	��Top=�6�   $��75��6�   $��20��6�   6�   �� 53   
   -
   5         ��Name$ txtiid��53      $��3��6#   $��2��67   $
��Left=�6G   $��23��6b   $��3��6n    �� TextWrapping$
 Wrap=�6{   $	��Top=�6�   $	��291��6�   $��0,10,0,0q�6�   $��2��6�   �� 54   
   -   5        $ 	txtsearch��54      $��4��6%   $
��Left=�65   $��31,8,0,0q�6P   $
 Wrap=�6b   $��search here��6v   $	��120��6�   $��2��6�   �� 55   
   -   5        $ txtiname��55      $��3��6$   $��2��68   $
��Left=�6H   $��23��6c   $��0,10,0,0q�6o   $��4��6�   $
 Wrap=�6�   $	��Top=�6�   $	��291��6�   $��2��6�   �� 56   
   -   5        $ txt_d��56      $��3��6!   $��2��65   $
��Left=�6E   $��24��6`   $��0,7,0,0q�6l   $��7��6}   $
 Wrap=�6�   $	��Top=�6�   $	��291��6�   �� 57   
   -   5        $ txt_s��57      $��3��6!   $��2��65   $
��Left=�6E   $��23��6`   $��0,11,0,0q�6l   $��5��6~   $
 Wrap=�6�   $	��Top=�6�   $	��291��6�   $��2��6�   �� 5;   
   $��Item ID��6   $
��Left=�6"   $��3��6=   $	��Top=�6J    J� RenderTransformOrigin$ 0.5,0.5&�6b   $��92��6�   
�������$��18(�6�   $
��Bold"�6�   $��41,0,0,0q�6�   $��2��6�   �� 5<   
   $��	Item Name��6   $
��Left=�6$   $��41,0,0,0q�6?   $��4��6Q   $	��Top=�6^   $��38��6v   
�������$��18(�6�   $
��Bold"�6�   $��2��6�   $	��139��6�   $��2��6�   �� 5=   
   $��Item Description��6   $
��Left=�6+   $��41,0,0,0q�6F   $��7��6X   $	��Top=�6e   
�������$��18(�6�   $
��Bold"�6�   $	��151��6�   $��2��6�   $��42��6�   $��2��6�   �� 5>   
   $��Supplier ID��6   $
��Left=�6&   $��41,0,0,0q�6A   $��5��6S   $	��Top=�6`   
�������$��18(�6�   $
��Bold"�6�   $ -0.022,0.521&�6�   $��2��6�   $	��139��6�   $��2��6�   �� 5?   
   $��Price��6   $
��Left=�6    $��41,0,0,0q�6;   $��6��6M   $	��Top=�6Z   $��31��6r   
�������$��18(�6�   $
��Bold"�6�   $	��181��6�   $��2��6�   �� 5@   
   -   5        $ txtre_o��5@      $��3��6#   $��2��67   $
��Left=�6G   $��23��6b   $��0,7,0,0q�6n   $��6��6   $
 Wrap=�6�   $	��Top=�6�   $	��291��6�   �� 5A   
   -   5        $ search��5A      $��S��6!   $��5��6-   $
��Left=�6=   $��59,8,0,0q�6X   $	��Top=�6j   $��46��6�   $ 0.534,1.414&�6�   $��2��6�   5E      5F      