   M S B A M L   `   `   `  ����J  FOutdoorWeather1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:OutdoorWeather1OutdoorWeather1  5   	        OutdoorWeather1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:OutdoorWeather1     5   	     � Title$  OutdoorWeather��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � WindowState$ 	Maximized=�6^    � 	Resources 5	      ��%    5
      .��5      � .+�5   
    � -   5          �Name$ FrameSetting��5      $��Center=�6&   $��Center=�6A   $��0,0,0,0q�5      $	��160��5      $	��196��6     � NavigationUIVisibility$ Hidden=�6)   5      �� 5   
   -   5         ��Name$
 Temp��5      $
��Wrap=�5      $	��120��5      $��630,46,50,332q�5      �� 5   
   -   5        $ ExeptionMessage��5      $
��Wrap=�5      $	��120��5   
   $��Center=�5   
   $��Center=�5   
   $��	0,-50,0,0q�5   
   �� 5   
   -   5         ��Name$ ButtonSettings��5      $��Right=�6)   $	��Top=�5      $��30��6)   $��30��65   $��15q�6@   ��5      Z� ��6(   Z� ��5      �� 5       j� Stretch$
 Fill=�6   	 �� ImageSource$	 /SettingIcon.png��6,   ��5       �� 5!      
 �� 
TargetType"
 ��6   .�5"      ��  �� Property �@�OverridesDefaultStyle �� Value . 6>   �� 5#       � �� 5$      �� 5%       �� 
TargetType" ��6.   .R�5&   "   �� $��Border��6)   $��0q�67   #��z��5'      ._�5(   &   �� $��Center=�67   $��Center=�5)      5*   #    �� Triggers 5+   "   :� 5,   &    :� RoutedEvent$ 
MouseEnter��63   .[�5-   *   �� .��5.   .   �� .��5/   2   W� 	 W� To$	 0.4X�6B    �� TargetProperty$ Opacity�50       g� Duration$ 	0:0:0.800D�51       g� AutoReverse .  g� RepeatBehavior$ Forever��52      53   /   54   +   55   '   :� 56   &   $ 
MouseLeave��63   .[�57   *   �� .��58   .   �� .��59   2   W� $ 1X�6B   $ Opacity�5:      $ 	0:0:0.800D�5;      W� 5<   2    W�Name$ WidthAnimation��5?      $ 30X�5<   B   $ Width�5=      $ 0:0:0.10D�5>      5?      W� 5@   2   $ 30X�6B   $ Height�5A      $ 0:0:0.10D�5B      5C   /   5D   +   5E   '   :� 5F   &   $ Button.Click��63   .[�5G   *   �� .��5H   .   �� .��5I   2   W� $ 28X�6B   $ Width�5J      $ 0:0:0.10D�5K      W� 5L   2   $ 28X�6B   $ Height�5M      $ 0:0:0.10D�5N      5O   /   5P   +   5Q   '   5S      5U      5V      5X      5Y      5Z      