   M S B A M L   `   `   `  ����U  QCase_Management_System_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Case_Management_System_WPF.Views Case_Management_System_WPF.Views  5      7    1Case_Management_System_WPF.Views.UpdateErrandView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Case_Management_System_WPF.Views     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��300 �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $
��auto �6   .+�5   
   �� ���#8C4872$��0��6%   $��0��62   $#��Uppdatera ett enskilt ärende��6B   $��18(�6j   �� 5   
   $��0��6   $��0��6!   $��2��61   $��2��6E   $��	10 30 0 0q�6V   $��14(�6i   $��SemiBold"�6w   20Välj ärende för att hämta kontaktinformation�� 6�   +)och ärendeinformation som ska uppdateras6�   �� 5   
   $��1��6   $��0��6!   $��	10 20 0 0q�61   $!��Antal ärenden i registret:��6D   6h   �� 5   
   -   5         ��Name$ AntalÄrenden��5   F   $��1��6   $��0��6!   $��
150 20 0 0q�61   6_   �� 5!   
   $��2��6   $��7��6"   $��0��63   $��0 0 0 0q�6C   .+�5"      �� $
��Auto=�6   $	��120��6>   $	��300��6K   $
��Left=�6W   .��5#      �� -   5         ��Name$ Errands��5#       � DataContext$. (Case_Management_System_WPF.Models.Errand��6-   $��10q�6d   ��5$      �� 5%      .R�5&      �� $ tbErrandTitle��6V   -   5         � Cursor$
 Hand��5&   (   $��12(�6�   $��SemiBold"�6�   $	��245��6�   ��6n   �� *Title+6�   5'      5)      5*      5+      �� 5-   
    �� Orientation$ 
Horizontal=�6   $��4��6/   $��0��6<   $��2��6L   $��10q�6]   .+�5.      �� $��Kund:��6   $��0 20 0 0q�6%   �� 5/      -   5        $ tbFirstName��5/      $��5 20 0 0q�6-   �� 50      -   5        $ 
tbLastName��50      $��5 20 0 0q�6,   51      �� 53   
   $��5��6   $��0��6"   $��10 0 0 0q�62   .+�54      �� $��Titel på ärendet*��6   $��0 0 0 5q�61   �� 55      -   5         ��Name$ tbTitle��55      56      �� 57   
   $��6��6   $��0��6"   $��10 0 0 0q�62   .+�58      �� $��Beskrivning av ärendet*��6   $��0 0 0 5q�67   �� 59      -   5        $ tbErrandDescription��59      5:      �� 5;   
   $��5��6   $��1��6"   $��10 0 0 0q�62   .+�5<      �� $��Handläggare*��6   $��0 0 0 5q�6,   �� 5=      -   5        $ tbAdminstrator��5=      5>      �� 5?   
   $��7��6   $��0��6"   $��	10 10 0 0q�63   .+�5@      �� -	   5         ��Name$ 
btnUppdate��5@   #   $
 Hand��6   $	��180��6P   $��Uppdatera ärende��6\   $��15(�6w   $��SemiBold"�6�   
����������#f5d07f$��30��6�   5A      �� 5B   
   -
   5        $ ErrandId��5B   &   $y�Hidden=�6   6:   �� 5E   
   $��1��6   $��6��6$   $��Status på ärendet*��61   $��	10 10 0 0q�6K   �� 5F   
   -   5        	 ��Name$	 cbNotStarted��5F   !   $��15(�6   $��1��67   $��6��6G   $��	10,30,0,0q�6T   $��Ärende ej påbörjat��5G      5H   '   �� 5K   
   -   5        $	 	cbStarted��5K   !   $��15(�6   $��1��64   $��7��6D   $��10,0,0,0q�6Q   $��Ärende under behandling��5L      5M   $   �� 5P   
   -   5        $	 
cbFinished��5P   !   $��15(�6   $��1��65   $��7��6E   $��	10,20,0,0q�6R   $��Ärende avslutat��5Q      5R   %   �� 5T   
   -   5        $ Status��5T   (   $y�Hidden=�6   $��1��68   $��7��6H   $��10,0,0,0q�6U   5W      5X      