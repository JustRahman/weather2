   M S B A M L   `   `   `  ����B  >weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:weather.Viewsweather.Views  5      5clr-namespace:weather.ModelViewweather.ModelView  5          weather.Views.View1   5      a ]DevExpress.Xpf.Core.v21.1, Version=21.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:weather.Views     5      e aDevExpress.Xpf.Controls.v21.1, Version=21.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aCdxwui7http://schemas.devexpress.com/winfx/2008/xaml/windowsui  5      ] YDevExpress.Mvvm.v21.1, Version=21.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   5	      OdxwuinBhttp://schemas.devexpress.com/winfx/2008/xaml/windowsui/navigation  5
      /	ModelViewclr-namespace:weather.ModelView  5      
������ .��5      �   � RowDefinitions  5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       .+�5#   
   �� $��0��6;   $��4��6K   $��4��6_   ��6   �� *all_background+.+�5&      � $��0 30 0 0q�6   .+�5'      �� $	��200��6   $	��200��6*   $��20 0 0 0q�67   $
��Left=�6o   ��6I   �� *all_background+.+�5(      �� $��Medium"�6:   $��Times New Roman)�6N   $��18(�6k   $��
20 10 0 20q�6�   ��6    �� *
wind_lan+��6y   �� *gray_to_black+6�   �� 5)      $��35(�6    $
��Bold"�6.   $��Times New Roman)�6@   $��
30 20 0 40q�6�   ��6]   �� *blact_to_white+��6�   �� *wind+6�   �� 5*       �� Orientation$ 
Horizontal=�6!   $��10 0 0 0q�6:   .+�5+      �� $>��8C:\Data\source\WPF\weather\bin\Debug\clothes\compass.png��6!   $��30��6c   �� 5,      
�������$��Medium"�6R   $��Times New Roman)�6f   $��18(�6�   $��5 4 0 0q�6�   ��6$   �� *	direction+6�   5.      5/      �� 50      $	��200��6   $	��200��6)   $��Center=�6]   ��67   �� *all_background+.+�51      �� $��Medium"�6>   $��Times New Roman)�6R   $��18(�6o   $��
20 10 0 20q�6�   ��6    �� *pressure_lan+��6}   �� *gray_to_black+6�   �� 52      $��35(�6    $
��Bold"�6.   $��Times New Roman)�6@   $��
30 20 0 40q�6�   ��6]   �� *blact_to_white+��6�   �� *
pressure+6�   �� 53      $ 
Horizontal=�6!   $��10 0 0 0q�6:   .+�54      �� $?��9C:\Data\source\WPF\weather\bin\Debug\clothes\pressure.jpg��6!   $��30��6d   �� 55      
�������$��Normal��66   $��Medium"�6D   $��Times New Roman)�6X   $��18(�6u   $��5 6 0 0q�6�   56      57      �� 58      $	��200��6   $	��200��6)   $��0 0 20 0q�66   $��Right=�6n   ��6H   �� *all_background+.+�59      �� $��Medium"�6>   $��Times New Roman)�6R   $��18(�6o   $��
20 10 0 20q�6�   ��6    �� *humidity_lan+��6}   �� *gray_to_black+6�   �� 5:      $��35(�6F   $
��Bold"�6T   $��Times New Roman)�6f   $��
30 20 0 40q�6�   ��6    �� *blact_to_white+��6�   �� *
humidity+6�   �� 5;      $ 
Horizontal=�6!   $��10 0 0 0q�6:   .+�5<      �� $��20��6=   ��6!   �� *
icon_hum+6=   �� 5=      
�������$��Medium"�6O   $��Times New Roman)�6c   $��18(�6�   $��5 6 0 0q�6�   ��66   �� *	quality+6�   5>      5?      5@      � 5B      $��0 30 0 0q�6   .+�5C      �� $	��200��6   $	��200��6)   $��20 0 0 0q�66   $
��Left=�6n   ��6H   �� *all_background+.+�5D      �� $��Medium"�6@   $��Times New Roman)�6T   $��18(�6q   $��
20 10 0 20q�6�   ��6    �� *visibility_lan+��6   �� *gray_to_black+6�   �� 5E      $��35(�6F   $
��Bold"�6T   $��Times New Roman)�6f   $��
30 20 0 40q�6�   ��6    �� *blact_to_white+��6�   �� *
visibility+6�   �� 5F      $ 
Horizontal=�6!   $��10 0 0 0q�6:   .+�5G      �� $A��;C:\Data\source\WPF\weather\bin\Debug\clothes\visibility.jpg��6!   $��25��6f   $��0 2 0 0q�6q   �� 5H      
�������$��Average��66   $��Medium"�6E   $��Times New Roman)�6Y   $��18(�6v   $��5 5 0 0q�6�   5I      5J      �� 5K      $	��200��6   $	��200��6)   $��Center=�6]   ��67   �� *all_background+.+�5L      �� $��Medium"�69   $��Times New Roman)�6M   $��18(�6j   $��
20 10 0 10q�6�   ��6    �� *	sunrise+��6x   �� *gray_to_black+6�   �� 5M      $ 
Horizontal=�6!   $��	20 0 0 20q�6:   .+�5N      �� $>��8C:\Data\source\WPF\weather\bin\Debug\clothes\sunrise.png��6!   $��60��6c   $��0 2 0 0q�6n   �� 5O      $��Medium"�6D   $��Times New Roman)�6X   $��25(�6u   $��5 15 0 0q�6�   ��6%   �� *startdatetime+��6�   �� *blact_to_white+6�   5P      �� 5Q      $ 
Horizontal=�6!   $��20 0 0 0q�6:   .+�5R      �� $=��7C:\Data\source\WPF\weather\bin\Debug\clothes\sunset.png��6!   $��60��6b   $��0 2 0 0q�6m   �� 5S      $��Medium"�6E   $��Times New Roman)�6Y   $��25(�6v   $��5 15 0 0q�6�   ��6%   �� *finishdatetime+��6�   �� *blact_to_white+6�   5T      5U      �� 5V      $	��200��6   $	��170��6)   $��Right=�67   $��0 0 20 0q�6S   .+�5W      �� $��	0 30 0 30q�6   
�������$��20(�6j   $��Times New Roman)�6�   $��SemiBold"�6�   $	��180��6  $��40��6  ��60   �� *all_background+��6x   �� *blact_to_white+��6�   �� *refresh_lan+��6�   �� *	refresh+6  �� 5Y      
�������$��20(�6}   $��Times New Roman)�6�   $��SemiBold"�6�   $	��180��6�   $��40��6  ��6   �� *blact_to_white+��6C   �� *all_background+��6�   �� *details_lan+��6�   �� *	details+6  5Z      5[      5]      5�      5�      