   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089_ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a  �� MergedDictionaries �� Source #  MaterialDesignPasswordBoxCustom �� 
TargetType �� Property �� Value �� RelativeSource �� AncestorType �� Path  MaterialDesignTextBoxBorder.   (MaterialDesignThemes.Wpf.TextFieldAssist(  "MaterialDesignThemes.Wpf.Constants   DefaultTextBoxViewMargin  PrimaryHueMidBrush  PrimaryHueLightBrush	   TextBoxDefaultPadding ) %MaterialDesignValidationErrorTemplate)  #MaterialDesignThemes.Wpf.HintAssist $  MaterialDesignDefaultContextMenu-   'System.Windows.Input.KeyboardNavigation
 �� 
TargetType - )MaterialDesignTextFieldBoxHoverBackground    TextFieldCornerRadius �� CornerRadius J� RenderTransformOrigin   BooleanToVisibilityConverter �� 	Converter �� ScaleX �� ScaleY ��Name �� Padding6  0MaterialDesignThemes.Wpf.BottomDashedLineAdorner   Brush   	Thickness J� SnapsToDevicePixels � ColumnDefinitions'  !MaterialDesignThemes.Wpf.PackIcon  Name    LeadingIconSize    LeadingIcon   Kind   HintOpacity J� Opacity �Name ��Name    
PrefixText  ��Name! K� ZIndex1  +MaterialDesignThemes.Wpf.ScrollViewerAssist"   IgnorePadding# � UseLayoutRounding(  "MaterialDesignThemes.Wpf.SmartHint$  Name%    TextBoxViewMargin&   FloatingOffset'   FloatingOffset(   FloatingScale)   FloatingScale*   
FontFamily+   HintOpacity,   
IsFloating-   UseFloating.   	HintProxyB  <MaterialDesignThemes.Wpf.Converters.HintProxyFabricConverter/   Instance0 �� 	Converter1   Hint2   
Background3 ��Name4   Hint5    
SuffixText6 ��Name  MaterialDesignToolButton "	 ClearButtonVisibilityConverter7 `� 	Converter8 �� ElementName9    UnderlineCornerRadius:    DecorationVisibility(	  "MaterialDesignThemes.Wpf.Underline; 	 Name<    UnderlineBrush= 	  CornerRadius
> �� Top?   HelperTextFontSize@   
HelperText'
   !System.Windows.VisualStateManagerA 
  VisualStateGroups%   System.Windows.VisualStateGroupB   States    System.Windows.VisualStateC   
StoryboardD �� 
TargetNameE �� TargetPropertyF W� From	G W� ToH g� DurationI W� EasingFunction-  'System.Windows.Media.Animation.SineEase7  1System.Windows.Media.Animation.EasingFunctionBaseJ   
EasingModeK g� 	BeginTimeL �� TriggersM ]� 
ConditionsN �� PropertyO �� ValueP �� 
TargetName *
 &FloatingHintOffsetCalculationConverterQ P� PropertyR P� Value ( $MaterialDesignTextFieldBoxBackground'S    DefaultTextBoxViewMarginEmbedded   MaterialDesignTextAreaBorderT �� 
SourceName  MaterialDesignPaperU   TextBoxNotEnabledOpacity ( $MaterialDesignTextAreaInactiveBorder  MathMultiplyConverterV �� ConverterParameter & "MaterialDesignValidationErrorBrush / +MaterialDesignFloatingHintPasswordBoxCustomW �� BasedOn ) %MaterialDesignFilledPasswordBoxCustom + 'MaterialDesignOutlinedPasswordBoxCustom�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      ;wpf1http://materialdesigninxaml.net/winfx/xaml/themes  5        5      �� 5   
   $w qpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ValidationErrorTemplate.xaml?�6   �� 5   
   $d ^pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Menu.xaml?�6   %�/  &	        7  7  7  7  7 	 7 
 7 
 7 
 7  &	 8-    7   &	 �-    7  &	 �.    7  �� 5      " G�64   .�5   
   ��  � �� 6'   ��  �� " �$ (TextElement.Foreground)��� 5   
    � ��# �  6(   �� 5   
    � ��$ 0,0,0,1q�6,   �� 5   
    �@  TextBoxViewMargin# Z 6B   �� 5   
    � ��
 ���� 6'   �� 5   
    �@G�
CaretBrush# �  6'   �� 5   
    �@G�SelectionBrush# �  6+   �� 5   
    � ��$ Stretch=�67   �� 5   
    � ��$	 Top=�65   �� 5   
    �@�FocusVisualStyle 6-   Z� �� 5   
    �@J�	AllowDrop . 6&   �� 5   
    � ��# Z	 6$   �� 5   
    �@��PanningMode$ VerticalFirst=�65   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    �@=�ErrorTemplate8   65   �� 5   
    �@  UnderlineBrush# �  6?   �� 5   
    �@ 
Foreground# �  66   �� 5   
    �@�ContextMenu8  6(   �� 5   
    �@�Cursor$ IBeam��6#   �� 5   
    �@ TabNavigation$
 None=�6=   �� 5    
    � �� 6'   ��  �� " �$ (TextElement.FontFamily)��� 5!   
    �@G�PasswordChar$	 ●��6)   �� 5"   
    � �� 5#      �� 5$      "
 G�6"   .R�5%      � .+�5&      �� $��Stretch=�5'      $��Stretch=�5(      #���  5)      # z 5*      $ 0.5,0.5&�5+      y�5,      �� **(wpf:TextFieldAssist.RippleOnFocusEnabled+8  z�5.      �� 5/   "   RippleOnFocusScaleTransform��$ 0Q�6V   $ 0Q�6a   51      �� 52      .u�53      �� $ border��54   !   # z��55   !   # z��56   !   # z��57   !   #��z��58   !   #��z��59   !   #��z��5:   !   # z 5;   !    . ._�5=   "   � #��z��6'   #��z��6j    5>   &   �� 5?   *   $
��Auto �6;   �� 5@   *   �� 5A   *   $
��Auto �6;   .+�5D   &     $ LeadingPackIcon��5E   )   $��0��5F   )   #��z 5G   )   #��z 5H   )   $��0,0,6,0q�5I   )   $��Center=�5J   )   # z 5K   )   # z 5L   )   y�5M   )   �� *$"wpf:TextFieldAssist.HasLeadingIcon+8  � 5P   &   $
 grid��5Q   )   $��1��5R   )   $��1��5S   )   $��Center=�5T   )    5U   *   �� 5V   .   $
��Auto �6?   �� 5W   .   $��* �6?   �� 5X   .   $
��Auto �6?   .+�5Z   *   �� $ PrefixTextBlock��5[   -   $��0��5\   -   #��z��5]   -   # z 5^   -   #��z 5_   -   �� 5`   *   $  PART_ContentHost��5a   -   $��1��5b   -   $! 1��5c   -   " . |�.  $��Hidden=�5f   -   # z 5g   -   ## z# 5h   -   $��Hidden=�5i   -     5j   *   $
$ Hint��5k   -   $��1��5l   -   #��z% 5m   -   #' z& 5n   -   #) z( 5o   -   #��z* 5p   -   #��z��5q   -   #+ z 5r   -   #- z, 5t   -   . 5s   -   ��  �� *TemplatedParent+#0 Z/ 1 5u   .   �� 5v   2   $ HintBackgroundBorder��5w   5   #��z2 5x   5   $ 2��5y   5   ._�5z   6   �� $3 HintWrapper��6G   #��z4 6\   5{   3   5}   +   �� 5~   *   $ SuffixTextBlock��5   -   $��2��5�   -   #��z��5�   -   # z 5�   -   #��z5 5�   -   5�   '   �� 5�   &   $6 PART_ClearButton��5�   )   $��2��5�   )   $
��Auto��5�   )   $��2,0,0,0q�5�   )   |�.  #���  5�   )   y�5�   *   `� 5�   .   87  .1�5�   2   �� $* $(wpf:TextFieldAssist.HasClearButton)�6:    6f   �� *TemplatedParent+�� 5�   2   $
8 Hint��6:   $ IsContentNullOrEmpty�6M   5�   /   .��5�   *     $��0q�67   $ CloseCircle=�6B   5�   '   5�   #   5�      5�      �� 5�      $ borderUnderline��5�      $��0��5�      $��Stretch=�5�      $��Bottom=�5�      #��z��5�      # z9 5�       . #y�z: 5�      	  5�      $; 	Underline��5�      #��z< 5�      #= z9 5�      #y�z: 5�      �� 5�      $��Bottom=�6!   .+�5�      �� $> 2��5�   !   #��z? 5�   !   # z 5�   !   #��z@ 5�   !   ��5�   !   �� *ActualWidth+$8 border��5�   !   5�      A 5�        5�      FocusStates��.B 5�   "     Focused��.C 5�   &   �� $!D RippleOnFocusScaleTransform��61   .��5�   *   W� $E ScaleX�5�   -   $F 0X�5�   -   $G 1X�5�   -   $H 0:0:0.3D�5�   -   I 5�   .     5�   2   $J EaseOut=�6;   5�   +   W� 5�   *   $E ScaleY�5�   -   $F 0X�5�   -   $G 1X�5�   -   $H 0:0:0.3D�5�   -   I 5�   .     5�   2   $J EaseOut=�6;   5�   +   W� 5�   *   $K 0:0:0.45X�5�   -   $E ScaleX�5�   -   $G 0X�5�   -   $H 0D�5�   -   W� 5�   *   $K 0:0:0.45X�5�   -   $E ScaleY�5�   -   $G 0X�5�   -   $H 0D�5�   -   5�   '   5�   #     5�   "   	Unfocused��.C 5�   &   �� $!D RippleOnFocusScaleTransform��61   .��5�   *   W� $E ScaleX�5�   -   $G 0X�5�   -   $H 0D�5�   -   W� 5�   *   $E ScaleY�5�   -   $G 0X�5�   -   $H 0D�5�   -   5�   '   5�   #   5�      5�      L 5�      ]� 5�      M 5�      �� 5�   "   N �@ 
IsFloatingO . 6Q   �� 5�   "   N �@J�IsKeyboardFocusedO . 6I   ./�5�      �� $
P Hint��6%    6M   �� $! (wpf:HintAssist.Foreground)� �� *TemplatedParent+ � ���� 5�      $
P Hint��6%    �@ HintOpacity$ 1Q�6N   5�      ]� 5�      M 5�      �� 5�   "   N �@ 
IsFloatingO . 6Q   �� 5�   "   N �@  HasOutlinedTextFieldO .  6`   ./�5�      �� $
P Hint��6%    �@ FloatingOffset 5�   "   `� 5�   &   87  .1�5�   *   �� $ 
FontFamily�62    6D   �� *TemplatedParent+�� 5�   *   $ FontSize�62    6B   �� *TemplatedParent+�� 5�   *   $$ (wpf:HintAssist.FloatingScale)�62    6X   �� *TemplatedParent+�� 5�   *   $% (wpf:HintAssist.FloatingOffset)�62    6Y   �� *TemplatedParent+5�   '   5�      �� 5�      $
P grid��6%    � �� 5�   "   `� 5�   &   87  .1�5�   *   �� $ 
FontFamily�62    6D   �� *TemplatedParent+�� 5�   *   $ FontSize�62    6B   �� *TemplatedParent+�� 5�   *   $$ (wpf:HintAssist.FloatingScale)�62    6X   �� *TemplatedParent+�� 5�   *   $% (wpf:HintAssist.FloatingOffset)�62    6Y   �� *TemplatedParent+5�   '   5�      5      P� 5     Q �@  HasFilledTextFieldR . . �5     ��  � ��$
 16,8q�68   �� 5     # �  6;    � ���� 5     # ZS 6V    �@  TextBoxViewMargin5     P� 5     Q �@  HasOutlinedTextFieldR . . �5     ��  � ��$	 Top=�6I   �� 5      � ��$ 1q�6@   �� 5	     # �  6<    � ���� 5
      � ��$ 16q�68   �� 5     # ZS 6V    �@  TextBoxViewMargin�� 5     $P 	Underline��6%    � y�$ 	Collapsed=�6R   �� 5     $
P Hint��6%    �@ HintOpacity$ 1Q�6N   �� 5     $P HintWrapper��6%    6Q   �� $" (wpf:HintAssist.HintOpacity)� �� *TemplatedParent+ �@J�Opacity�� 5     $
P Hint��6%    �@ FloatingOffset 5  "   `� 5  &   87  .1�5  *   �� $ 
FontFamily�62    6D   �� *TemplatedParent+�� 5  *   $ FontSize�62    6B   �� *TemplatedParent+�� 5  *   $$ (wpf:HintAssist.FloatingScale)�62    6X   �� *TemplatedParent+�� 5  *   $% (wpf:HintAssist.FloatingOffset)�62    6Y   �� *TemplatedParent+�� 5  *   $ ActualHeight�62    6F   �� *TemplatedParent+5  '   5     5     ]� 5     M 5     �� 5  "   N �@  HasOutlinedTextFieldO . 6`   �� 5  "   N �@ 
IsFloatingO . 6Q   �� 5  "   $
T Hint��6,    N �@ IsHintInFloatingPositionO . 6b   ./�5!     �� $P HintBackgroundBorder��6%    �@��Padding$	 4,0q�6Z   �� 5"     # �  6J    �@ 
Background5#     ]� 5$     M 5%     �� 5&  "   N �@  HasOutlinedTextFieldO . 6`   �� 5'  "   N �@ 
IsFloatingO . 6Q   �� 5(  "   N �@J�IsKeyboardFocusedO . 6I   ./�5*     �� $P HintWrapper��6%    �@J�Opacity$ 1Q�6Q   5+     ]� 5.     M 5/     �� 50  "   N � {�O .  6A   �� 51  "   N �@  HasOutlinedTextFieldO .  6`   ./�53     �� $P border��6%    � ��
 ���� 6P   54     ]� 55     M 56     �� 57  "   N � {�O .  6A   �� 58  "   N �@  HasOutlinedTextFieldO .  6`   �� 59  "   N �@  HasFilledTextFieldO .  6^   ./�5;     �� $
P grid��6%   # ZU 6J    �@J�Opacity�� 5<     $P border��6%    �@ 
IsAttached . 6k   �� 5=     $P borderUnderline��6%    � ��$ 0��6T   5>     ]� 5?     M 5@     �� 5A  "   N � {�O .  6A   �� 5B  "   N �@  HasFilledTextFieldO . 6^   ./�5D     �� $P border��6%   # ZU 6L    �@J�Opacity�� 5E     $P borderUnderline��6%   # ZU 6U    �@J�Opacity�� 5F     $P borderUnderline��6%    � ��$ 1��6T   5G     ]� 5H     M 5I     �� 5J  "   N � {�O .  6A   �� 5K  "   N �@  HasOutlinedTextFieldO . 6`   ./�5M     �� # �  6<    � ���� 5N     $P PrefixTextBlock��6%   # ZU 6U    �@J�Opacity�� 5O     $P PART_ContentHost��6%   # ZU 6V    �@J�Opacity�� 5P     $P SuffixTextBlock��6%   # ZU 6U    �@J�Opacity�� 5Q     $P PART_ClearButton��6%   # ZU 6V    �@J�Opacity�� 5R     $P HintWrapper��6%    �@J�Opacity 5S  "   �� 5T  &   80  #V ZU 5V  )   $" (wpf:HintAssist.HintOpacity)�5W  )    5X  )   �� *TemplatedParent+5Z     5[     P� 5^     Q �@J�IsKeyboardFocusedR . . �5_     �� $P 	Underline��6%    �@	 IsActive . 6P   5`     ]� 5a     M 5b     �� 5c  "   N �@J�IsKeyboardFocusedO . 6I   �� 5d  "   N �@  HasOutlinedTextFieldO . 6`   ./�5f     �� $P border��6%    � ��$ -1q�6K   �� 5g      � ��$ 2q�6@   �� 5h      6<   �� $* $(wpf:TextFieldAssist.UnderlineBrush)� �� *Self+ � ��5i     ]� 5j     M 5k     �� 5l  "   N �@J�IsKeyboardFocusedO . 6I   �� 5m  "   N �@  HasFilledTextFieldO . 6^   ./�5o     �� $P borderUnderline��6%    � ��$ 2��6T   5p     ]� 5s     M 5t     �� 5u  "   N �@J�IsMouseOverO . 6C   �� 5v  "   N �@  HasFilledTextFieldO .  6^   �� 5w  "   N �@  HasOutlinedTextFieldO .  6`   �� 5x  "   "N �@  NewSpecHighlightingEnabledO .  6f   ./�5z     ��  6<   �� $* $(wpf:TextFieldAssist.UnderlineBrush)� �� *Self+ � ��5{     ]� 5|     M 5}     �� 5~  "   N �@J�IsMouseOverO . 6C   �� 5  "   N �@  HasFilledTextFieldO .  6^   �� 5�  "   N �@  HasOutlinedTextFieldO .  6`   �� 5�  "   "N �@  NewSpecHighlightingEnabledO . 6f   ./�5�     �� $P border��6%    � ��$ 0,0,0,2q�6T   �� 5�     $P border��6%    �@��Padding$ 0,4,0,3q�6L   5�     ]� 5�     M 5�     �� 5�  "   N �@J�IsMouseOverO . 6C   �� 5�  "   N �@  HasFilledTextFieldO . 6^   ./�5�     �� # �  6;    � ���� 5�     $P borderUnderline��6%    � ��$ 1��6T   5�     ]� 5�     M 5�     �� 5�  "   N �@J�IsMouseOverO . 6C   �� 5�  "   N �@  HasOutlinedTextFieldO . 6`   ./�5�     �� $P border��6%    � ��$ -1q�6K   �� 5�      � ��$ 2q�6@   5�     P� 5�     Q �@=�HasErrorR . . �5�     �� # �  6<    � ���� 5�     $P 	Underline��6%   # �  6R    � ��5�     ]� 5�     M 5�     �� 5�  "   N �@=�HasErrorO . 6K   �� 5�  "   N �@  HasOutlinedTextFieldO . 6`   ./�5�     �� $P border��6%    � ��$ -1q�6K   �� 5�      � ��$ 2q�6@   �� 5�     # �  6<    � ��5�     5�     5�     5�     �� 5�     8W   " G�5�  	   .�5�  
   ��  �@ 
IsFloating . 66   5�     �� 5�     8W   " G�5�  	   .�5�  
   ��  �@  HasFilledTextField . 6C   �� 5�  
    �@  RippleOnFocusEnabled . 6E   �� 5�  
    �@  TextFieldCornerRadius$ 4,4,0,0��6F   �� 5�  
    �@  UnderlineCornerRadius$ 0��6F   5�     �� 5�     8W   " G�5�  	   .�5�  
   ��  �@  HasOutlinedTextField . 6E   �� 5�  
    �@  TextFieldCornerRadius$ 4��6F   5�     5�     