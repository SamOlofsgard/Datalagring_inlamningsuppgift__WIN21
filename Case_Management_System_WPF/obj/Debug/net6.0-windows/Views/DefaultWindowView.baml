   M S B A M L   `   `   `  ����U  QCase_Management_System_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Case_Management_System_WPF.Views Case_Management_System_WPF.Views  5      8    2Case_Management_System_WPF.Views.DefaultWindowView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Case_Management_System_WPF.Views     5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��300 �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��70 �6   �� 5      $	��100 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $
��auto �6   .+�5   
   �� ���#8C4872$��0��6%   $��0��62   $��2��6B   $;��5Senaste ärenden och aktuell status på alla ärenden��6W   $��18(�6�   �� 5   
   $��
-15 10 0 0q�6   $��0��6%   $��1��62   $��2��6B   .+�5      ��  �� RadiusX$ 5��6    �� RadiusY$ 5��6$    �� Left$ 10��60   
 �� Top$ 27��6A   $��70��6Q   $	��220��6]   
���   �$	��0.5��6x   ���#ECEEFF6�   �� 5      -   5         ��Name$ StatusÄrenden��5      $��	17 30 0 0q�60   $��SemiBold"�6C   6\   5       �� 5!   
   .+�5"      �� $ 5��6   $ 5��6$   $ 30��60   $ 35��6A   $	��400��6Q   $	��210��6^   
���   �$	��0.5��6y   ���#ECEEFF6�   5#      �� 5$   
   $��0��6   $��0��6!   $��2��61   $��	40 40 0 0q�6B   $��14(�6U   $��SemiBold"�6c   Välj ärende för att hämta�� 6�   kontaktinformation och�� 6�   ärendeinformation6�   �� 5%   
   $��2��6   $��0��6!   $��	40 20 0 0q�61   $"��10 Senaste ärenden inlagda:��6D   6i   �� 5'   
   $��2��6   $��7��6"   $��0��63   $��30q�6C   .+�5(      �� $
��Auto=�6   $	��225��6?   $	��200��6L   $
��Left=�6X   .��5)      �� -   5         ��Name$ Errands��5)       � DataContext$. (Case_Management_System_WPF.Models.Errand��6,   $��10q�6c   ��5*      �� 5+      .R�5,      �� $ tbErrandTitle��6C   -   5        $	��160��5,   (   	 � Cursor$
	 Hand��64   $��12(�6�   $��SemiBold"�6�   ��6{   �� *Title+6�   5-      5/      50      51      �� 55   
   
 �� Orientation$
 
Horizontal=�6   $��2��6.   $��1��6;   $��5q�6K   .+�56      �� .+�57      �� $ 5��6   $ 5��6(   $	 -10��64   $ 8��6F   $	��320��6U   $	��220��6b   
���   �$	��0.5��6}   ���#ECEEFF6�   58      �� 59      $��Kontaktinformation��6   $
��Bold"�62   $��15(�6D   $��0 10 0 5q�6R   5:      �� 5;   
   $
 
Horizontal=�6   $��3��6.   $��1��6;   $��5q�6K   .+�5<      �� -   5        $ tbFirstName��5<      $��15(�6-   $��	0 -15 0 5q�6;   �� 5=      -   5        $ 
tbLastName��5=      $��15(�6,   $��	5 -15 0 5q�6:   5?      �� 5@   
   $
 Vertical=�6   $��4��6,   $��1��69   $��5q�6I   .+�5A      �� -   5        $ tbEmail��5A      $��15(�6)   $��	0 -15 0 0q�67   �� 5B      -   5        $ tbPhone��5B      $��15(�6)   $��0 0 0 0q�67   �� 5C      -   5        $ tbMobile��5C      $��15(�6*   5D      �� 5F   
   $��5��6   $��1��6"   $��5q�62   .+�5G      �� $��Ärendeinformation��6   $
��Bold"�61   $��15(�6C   $��	0 -10 0 5q�6Q   �� 5H      -	   5        $ tbErrandDescription��5H      $�� ��65   $��15(�6=   $��0 -5 0 5q�6K   5I      �� 5J   
   $��6��6   $��1��6"   $
 
Horizontal=�62   $��	5 -25 0 0q�6L   .+�5K      �� $��Skapat:��6   $��15(�6'   $��0 10 0 0q�65   �� 5L      -
   5        $ 	tbCreated��5L      $�� ��6+   $��15(�63   $��5 10 0 0q�6A   5M      �� 5N   
   $��6��6   $��1��6"   $
 
Horizontal=�62   $��5 0 0 0q�6K   .+�5O      �� $��Ändrat:��6   $��15(�6'   $��0 10 0 0q�65   �� 5P      -   5        $ 	tbChanged��5P      $�� ��6+   $��15(�63   $��5 10 0 0q�6A   5Q      �� 5R   
   $��7��6   $��1��6"   $
 
Horizontal=�62   $��	5 -27 0 0q�6K   .+�5S      �� $��Status:��6   $��15(�6'   $��0 10 0 0q�65   �� 5T      -   5        $ tbStatus��5T      $�� ��6*   $��15(�62   $��5 10 0 0q�6@   5U      �� 5V   
   $��7��6   $��1��6"   $
 
Horizontal=�62   $��5 0 0 0q�6K   .+�5W      �� $��Handläggare:��6   $��15(�6,   $��0 5 0 0q�6:   �� 5X      -   5        $ tbAdminstrator��5X      $�� ��60   $��15(�68   $��5 5 0 0q�6F   5Y      5[      5\      