﻿using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using XamlIcons.Commands;
using XamlIcons.Model;

namespace XamlIcons.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<IconModel> _icons = new ObservableCollection<IconModel>();
        private IconModel _selectedIcon;
        private int _selectedIndex;
        private bool _fillIcon;
        

        public MainWindowViewModel()
        {
            GetIcons();

            _selectedIndex = 0;

            GetSelectedIcon();

            InitCommands();
        }

        private void GetIcons()
        {
            Icons.Add(new IconModel("3D Rotation", "F1 M24,24z M0,0z M7.52,21.48C4.25,19.94,1.91,16.76,1.55,13L0.05,13C0.56,19.16,5.71,24,12,24L12.66,23.97 8.85,20.16 7.52,21.48z M8.41,14.96C8.22,14.96 8.04,14.93 7.89,14.88 7.73,14.82 7.6,14.75 7.49,14.64 7.38,14.54 7.29,14.42 7.23,14.27 7.17,14.13 7.14,13.97 7.14,13.8L5.84,13.8C5.84,14.16 5.91,14.48 6.05,14.75 6.19,15.02 6.38,15.25 6.61,15.44 6.85,15.62 7.12,15.76 7.43,15.85 7.73,15.95 8.05,16 8.39,16 8.76,16 9.11,15.95 9.42,15.85 9.74,15.75 10.02,15.6 10.25,15.41 10.48,15.22 10.67,14.98 10.8,14.69 10.93,14.4 11,14.08 11,13.72 11,13.53 10.98,13.34 10.93,13.16 10.88,12.98 10.81,12.81 10.7,12.65 10.6,12.49 10.46,12.35 10.3,12.22 10.13,12.09 9.93,11.99 9.69,11.91 9.89,11.82 10.06,11.71 10.21,11.58 10.36,11.45 10.48,11.31 10.58,11.16 10.68,11.01 10.75,10.86 10.8,10.7 10.85,10.54 10.87,10.38 10.87,10.22 10.87,9.86 10.81,9.54 10.69,9.26 10.57,8.98 10.4,8.75 10.18,8.57 9.98,8.38 9.71,8.24 9.41,8.14 9.1,8.05 8.76,8 8.39,8 8.03,8 7.7,8.05 7.39,8.16 7.09,8.27 6.82,8.42 6.6,8.61 6.39,8.8 6.22,9.02 6.09,9.28 5.97,9.54 5.91,9.82 5.91,10.13L7.21,10.13C7.21,9.96 7.24,9.81 7.3,9.68 7.36,9.55 7.44,9.43 7.55,9.34 7.66,9.25 7.78,9.17 7.93,9.12 8.08,9.07 8.23,9.04 8.41,9.04 8.81,9.04 9.11,9.14 9.3,9.35 9.49,9.55 9.59,9.84 9.59,10.21 9.59,10.39 9.56,10.55 9.51,10.7 9.46,10.85 9.37,10.97 9.26,11.07 9.15,11.17 9.01,11.25 8.85,11.31 8.69,11.37 8.49,11.4 8.27,11.4L7.5,11.4 7.5,12.43 8.27,12.43C8.49,12.43 8.69,12.45 8.87,12.5 9.05,12.55 9.2,12.63 9.32,12.73 9.44,12.84 9.54,12.97 9.61,13.13 9.68,13.29 9.71,13.48 9.71,13.7 9.71,14.11 9.59,14.42 9.36,14.63 9.13,14.86 8.81,14.96 8.41,14.96z M16.96,9.04C16.64,8.71 16.26,8.45 15.82,8.27 15.39,8.09 14.9,8 14.36,8L12,8 12,16 14.3,16C14.85,16 15.36,15.91 15.81,15.73 16.26,15.55 16.65,15.3 16.97,14.97 17.29,14.64 17.54,14.24 17.71,13.78 17.88,13.31 17.97,12.79 17.97,12.21L17.97,11.81C17.97,11.23 17.88,10.71 17.71,10.24 17.53,9.77 17.28,9.37 16.96,9.04z M16.57,12.2C16.57,12.62 16.52,12.99 16.43,13.33 16.33,13.66 16.19,13.95 16,14.18 15.81,14.41 15.57,14.59 15.29,14.71 15,14.83 14.67,14.89 14.3,14.89L13.39,14.89 13.39,9.12 14.36,9.12C15.08,9.12 15.63,9.35 16,9.81 16.38,10.27 16.57,10.93 16.57,11.8L16.57,12.2z M12,0L11.34,0.03 15.15,3.84 16.48,2.51C19.75,4.06,22.09,7.23,22.44,10.99L23.94,10.99C23.44,4.84,18.29,0,12,0z"));
            Icons.Add(new IconModel("Accessibility", "F1 M24,24z M0,0z M12,2C13.1,2 14,2.9 14,4 14,5.1 13.1,6 12,6 10.9,6 10,5.1 10,4 10,2.9 10.9,2 12,2z M21,9L15,9 15,22 13,22 13,16 11,16 11,22 9,22 9,9 3,9 3,7 21,7 21,9z"));
            Icons.Add(new IconModel("Accessible", "F1 M24,24z M0,0z M19,13L19,11C17.46,11.02,15.91,10.25,14.93,9.17L13.64,7.74C13.47,7.55 13.26,7.4 13.03,7.29 13.02,7.29 13.02,7.28 13.01,7.28L13,7.28C12.65,7.08 12.25,6.98 11.81,7.02 10.76,7.11 10,8.04 10,9.09L10,15C10,16.1,10.9,17,12,17L17,17 17,22 19,22 19,16.5C19,15.4,18.1,14.5,17,14.5L14,14.5 14,11.05C15.29,12.12,17.25,12.99,19,13z M12.83,18C12.42,19.16 11.31,20 10,20 8.34,20 7,18.66 7,17 7,15.69 7.84,14.59 9,14.17L9,12.1C6.72,12.56 5,14.58 5,17 5,19.76 7.24,22 10,22 12.42,22 14.44,20.28 14.9,18L12.83,18z"));
            Icons.Add(new IconModel("Account Balance", "F1 M24,24z M0,0z M4,10L4,17 7,17 7,10 4,10z M10,10L10,17 13,17 13,10 10,10z M2,22L21,22 21,19 2,19 2,22z M16,10L16,17 19,17 19,10 16,10z M11.5,1L2,6 2,8 21,8 21,6 11.5,1z"));
            Icons.Add(new IconModel("Running Man", "M297.290,51.396 C262.000,50.999 246.954,83.495 261.290,124.396 L258.5,132.5 229,124 162,145.5 C152.854,152.268 150.539,159.446 154.5,167 L174,223 C185.691,236.661 193.877,234.414 198.5,216 L182,168.5 224,154.5 228.5,170.5 220,226 167.5,279.5 114,254.5 96.5,256 75.5,292.5 C78.181,308.041 85.564,312.972 98,306.5 L112,281.5 156,304 C165.007,311.500 172.673,311.331 179,303.5 L213,268.5 230.5,263.5 255,269 311,297 304,340.5 C301.959,349.296 303.918,355.654 310,359.5 L336,376.5 C352.586,380.964 356.915,374.496 350,358 L332,343.5 337,297 C338.268,286.908 333.850,279.974 325,275.5 L277.5,250 295.5,191 303.5,200 316.5,234.5 C323.303,246.152 331.801,248.497 342,241.5 L390,206 C397.694,190.695 392.958,184.365 376.5,186.5 L337,213 318.5,167 310.5,157.5 287.5,146.5 286,135 C333.000,124.000 333.500,68.499 297.290,51.396 z"));
            Icons.Add(new IconModel("Swap horiz", "F1 M24,24z M0,0z M6.99,11L3,15 6.99,19 6.99,16 14,16 14,14 6.99,14 6.99,11z M21,9L17.01,5 17.01,8 10,8 10,10 17.01,10 17.01,13 21,9z"));
            Icons.Add(new IconModel("Forward 5", "F1 M24,24z M0,0z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z M10.7,13.9L10.9,11.7 13.3,11.7 13.3,12.4 11.6,12.4 11.5,13.3C11.5,13.3 11.6,13.3 11.6,13.2 11.6,13.1 11.7,13.2 11.7,13.1 11.7,13 11.8,13.1 11.9,13.1L12.1,13.1C12.3,13.1 12.5,13.1 12.6,13.2 12.7,13.3 12.9,13.4 13,13.5 13.1,13.6 13.2,13.8 13.3,14 13.4,14.2 13.4,14.4 13.4,14.6 13.4,14.8 13.4,15 13.3,15.1 13.2,15.2 13.2,15.4 13,15.6 12.8,15.8 12.7,15.8 12.5,15.9 12.3,16 12.1,16 11.9,16 11.7,16 11.5,16 11.4,15.9 11.3,15.8 11.1,15.8 10.9,15.7 10.7,15.6 10.7,15.5 10.6,15.3 10.5,15.1 10.5,15 10.5,14.8L11.3,14.8C11.3,15 11.4,15.1 11.5,15.2 11.6,15.3 11.7,15.3 11.9,15.3 12,15.3 12.1,15.3 12.2,15.2L12.4,15C12.4,15,12.5,14.8,12.5,14.7L12.5,14.1 12.4,13.9 12.2,13.7C12.2,13.7,12,13.6,11.9,13.6L11.7,13.6C11.7,13.6 11.6,13.6 11.5,13.7 11.4,13.8 11.4,13.7 11.4,13.8 11.4,13.9 11.3,13.9 11.3,13.9L10.7,13.9z"));
            Icons.Add(new IconModel("Forward 10", "F1 M24,24z M0,0z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z M10.8,16L10,16 10,12.7 9,13 9,12.3 10.8,11.7 10.9,11.7 10.9,16z M15.1,14.2C15.1,14.5,15.1,14.8,15,15L14.7,15.6C14.7,15.6 14.4,15.9 14.2,15.9 14,15.9 13.8,16 13.6,16 13.4,16 13.2,16 13,15.9 12.8,15.8 12.7,15.7 12.5,15.6 12.3,15.5 12.3,15.3 12.2,15 12.1,14.7 12.1,14.5 12.1,14.2L12.1,13.5C12.1,13.2,12.1,12.9,12.2,12.7L12.5,12.1C12.5,12.1 12.8,11.8 13,11.8 13.2,11.8 13.4,11.7 13.6,11.7 13.8,11.7 14,11.7 14.2,11.8 14.4,11.9 14.5,12 14.7,12.1 14.9,12.2 14.9,12.4 15,12.7 15.1,13 15.1,13.2 15.1,13.5L15.1,14.2z M14.3,13.4L14.3,12.9C14.3,12.9 14.2,12.7 14.2,12.6 14.2,12.5 14.1,12.5 14,12.4 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.3 13.5,12.3 13.4,12.4L13.2,12.6C13.2,12.6,13.1,12.8,13.1,12.9L13.1,14.9C13.1,14.9 13.2,15.1 13.2,15.2 13.2,15.3 13.3,15.3 13.4,15.4 13.5,15.5 13.6,15.5 13.7,15.5 13.8,15.5 13.9,15.5 14,15.4L14.2,15.2C14.2,15.2,14.3,15,14.3,14.9L14.3,13.4z"));
            Icons.Add(new IconModel("Forward 30", "F1 M24,24z M0,0z M9.6,13.5L10,13.5C10.2,13.5 10.4,13.4 10.5,13.3 10.6,13.2 10.7,13.1 10.7,12.9L10.7,12.7C10.7,12.7 10.6,12.6 10.6,12.5 10.6,12.4 10.5,12.4 10.4,12.4L9.9,12.4C9.9,12.4 9.8,12.5 9.7,12.5 9.6,12.5 9.6,12.6 9.6,12.7L9.6,12.9 8.6,12.9C8.6,12.7 8.6,12.6 8.7,12.4 8.8,12.2 8.9,12.1 9,12 9.1,11.9 9.3,11.8 9.4,11.8 9.5,11.8 9.8,11.7 9.9,11.7 10.1,11.7 10.3,11.7 10.5,11.8 10.7,11.9 10.8,11.9 11,12 11.2,12.1 11.2,12.2 11.3,12.4 11.4,12.6 11.4,12.7 11.4,12.9L11.4,13.2C11.4,13.2 11.3,13.4 11.3,13.5 11.3,13.6 11.2,13.7 11.1,13.7 11,13.7 10.9,13.8 10.8,13.9 11,14 11.2,14.1 11.3,14.3 11.4,14.5 11.5,14.7 11.5,14.9 11.5,15.1 11.5,15.3 11.4,15.4 11.3,15.5 11.2,15.7 11.1,15.8 11,15.9 10.8,16 10.6,16 10.4,16 10.2,16.1 10,16.1 9.8,16.1 9.6,16.1 9.5,16 9.4,15.9 9.2,15.9 9,15.8 8.8,15.7 8.8,15.6 8.7,15.4 8.6,15.2 8.6,15 8.6,14.8L9.4,14.8 9.4,15C9.4,15 9.5,15.1 9.5,15.2 9.5,15.3 9.6,15.3 9.7,15.3L10.2,15.3C10.2,15.3 10.3,15.2 10.4,15.2 10.5,15.2 10.5,15.1 10.5,15L10.5,14.5C10.5,14.5 10.4,14.4 10.4,14.3 10.4,14.2 10.3,14.2 10.2,14.2L9.6,14.2 9.6,13.5z M15.3,14.2C15.3,14.5,15.3,14.8,15.2,15L14.9,15.6C14.9,15.6 14.6,15.9 14.4,15.9 14.2,15.9 14,16 13.8,16 13.6,16 13.4,16 13.2,15.9 13,15.8 12.9,15.7 12.7,15.6 12.5,15.5 12.5,15.3 12.4,15 12.3,14.7 12.3,14.5 12.3,14.2L12.3,13.5C12.3,13.2,12.3,12.9,12.4,12.7L12.7,12.1C12.7,12.1 13,11.8 13.2,11.8 13.4,11.8 13.6,11.7 13.8,11.7 14,11.7 14.2,11.7 14.4,11.8 14.6,11.9 14.7,12 14.9,12.1 15.1,12.2 15.1,12.4 15.2,12.7 15.3,13 15.3,13.2 15.3,13.5L15.3,14.2z M14.4,13.4L14.4,12.9C14.4,12.9 14.3,12.7 14.3,12.6 14.3,12.5 14.2,12.5 14.1,12.4 14,12.3 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.3 13.5,12.4L13.3,12.6C13.3,12.6,13.2,12.8,13.2,12.9L13.2,14.9C13.2,14.9 13.3,15.1 13.3,15.2 13.3,15.3 13.4,15.3 13.5,15.4 13.6,15.5 13.7,15.5 13.8,15.5 13.9,15.5 14,15.5 14.1,15.4L14.3,15.2C14.3,15.2,14.4,15,14.4,14.9L14.4,13.4z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z"));
            Icons.Add(new IconModel("Replay", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.31,7 18,9.69 18,13 18,16.31 15.31,19 12,19 8.69,19 6,16.31 6,13L4,13C4,17.42 7.58,21 12,21 16.42,21 20,17.42 20,13 20,8.58 16.42,5 12,5z"));
            Icons.Add(new IconModel("Replay 5", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.3,7 18,9.7 18,13 18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13L4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13 20,8.6 16.4,5 12,5z M10.7,13.9L10.9,11.7 13.3,11.7 13.3,12.4 11.6,12.4 11.5,13.3C11.5,13.3 11.6,13.3 11.6,13.2 11.6,13.1 11.7,13.2 11.7,13.1 11.7,13 11.8,13.1 11.9,13.1L12.1,13.1C12.3,13.1 12.5,13.1 12.6,13.2 12.7,13.3 12.9,13.4 13,13.5 13.1,13.6 13.2,13.8 13.3,14 13.4,14.2 13.4,14.4 13.4,14.6 13.4,14.8 13.4,15 13.3,15.1 13.2,15.2 13.2,15.4 13,15.6 12.8,15.8 12.7,15.8 12.6,15.9 12.5,16 12.2,16 12,16 11.8,16 11.6,16 11.5,15.9 11.4,15.8 11.2,15.8 11,15.7 10.8,15.6 10.8,15.5 10.7,15.3 10.6,15.1 10.6,15 10.6,14.8L11.4,14.8C11.4,15 11.5,15.1 11.6,15.2 11.7,15.3 11.8,15.3 12,15.3 12.1,15.3 12.2,15.3 12.3,15.2L12.5,15C12.5,15,12.6,14.8,12.6,14.7L12.6,14.1 12.5,13.9 12.3,13.7C12.3,13.7,12.1,13.6,12,13.6L11.8,13.6C11.8,13.6 11.7,13.6 11.6,13.7 11.5,13.8 11.5,13.7 11.5,13.8 11.5,13.9 11.4,13.9 11.4,13.9L10.7,13.9z"));
            Icons.Add(new IconModel("Replay 10", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.3,7 18,9.7 18,13 18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13L4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13 20,8.6 16.4,5 12,5z M10.9,16L10,16 10,12.7 9,13 9,12.3 10.8,11.7 10.9,11.7 10.9,16z M15.2,14.2C15.2,14.5,15.2,14.8,15.1,15L14.8,15.6C14.8,15.6 14.5,15.9 14.3,15.9 14.1,15.9 13.9,16 13.7,16 13.5,16 13.3,16 13.1,15.9 12.9,15.8 12.8,15.7 12.6,15.6 12.4,15.5 12.4,15.3 12.3,15 12.2,14.7 12.2,14.5 12.2,14.2L12.2,13.5C12.2,13.2,12.2,12.9,12.3,12.7L12.6,12.1C12.6,12.1 12.9,11.8 13.1,11.8 13.3,11.8 13.5,11.7 13.7,11.7 13.9,11.7 14.1,11.7 14.3,11.8 14.5,11.9 14.6,12 14.8,12.1 15,12.2 15,12.4 15.1,12.7 15.2,13 15.2,13.2 15.2,13.5L15.2,14.2z M14.3,13.4L14.3,12.9C14.3,12.9 14.2,12.7 14.2,12.6 14.2,12.5 14.1,12.5 14,12.4 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.3 13.5,12.3 13.4,12.4L13.2,12.6C13.2,12.6,13.1,12.8,13.1,12.9L13.1,14.9C13.1,14.9 13.2,15.1 13.2,15.2 13.2,15.3 13.3,15.3 13.4,15.4 13.5,15.5 13.6,15.5 13.7,15.5 13.8,15.5 13.9,15.5 14,15.4L14.2,15.2C14.2,15.2,14.3,15,14.3,14.9L14.3,13.4z"));
            Icons.Add(new IconModel("Replay 30", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.3,7 18,9.7 18,13 18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13L4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13 20,8.6 16.4,5 12,5z M9.6,13.5L10,13.5C10.2,13.5 10.4,13.4 10.5,13.3 10.6,13.2 10.7,13.1 10.7,12.9L10.7,12.7C10.7,12.7 10.6,12.6 10.6,12.5 10.6,12.4 10.5,12.4 10.4,12.4L9.9,12.4C9.9,12.4 9.8,12.5 9.7,12.5 9.6,12.5 9.6,12.6 9.6,12.7L9.6,12.9 8.6,12.9C8.6,12.7 8.6,12.6 8.7,12.4 8.8,12.2 8.9,12.1 9,12 9.1,11.9 9.3,11.8 9.4,11.8 9.5,11.8 9.8,11.7 9.9,11.7 10.1,11.7 10.3,11.7 10.5,11.8 10.7,11.9 10.8,11.9 11,12 11.2,12.1 11.2,12.2 11.3,12.4 11.4,12.6 11.4,12.7 11.4,12.9L11.4,13.2C11.4,13.2 11.3,13.4 11.3,13.5 11.3,13.6 11.2,13.7 11.1,13.7 11,13.7 10.9,13.8 10.8,13.9 11,14 11.2,14.1 11.3,14.3 11.4,14.5 11.5,14.7 11.5,14.9 11.5,15.1 11.5,15.3 11.4,15.4 11.3,15.5 11.2,15.7 11.1,15.8 11,15.9 10.8,16 10.6,16 10.4,16 10.2,16.1 10,16.1 9.8,16.1 9.6,16.1 9.5,16 9.4,15.9 9.2,15.9 9,15.8 8.8,15.7 8.8,15.6 8.7,15.4 8.6,15.2 8.6,15 8.6,14.8L9.4,14.8 9.4,15C9.4,15 9.5,15.1 9.5,15.2 9.5,15.3 9.6,15.3 9.7,15.3L10.2,15.3C10.2,15.3 10.3,15.2 10.4,15.2 10.5,15.2 10.5,15.1 10.5,15L10.5,14.5C10.5,14.5 10.4,14.4 10.4,14.3 10.4,14.2 10.3,14.2 10.2,14.2L9.6,14.2 9.6,13.5z M15.3,14.2C15.3,14.5,15.3,14.8,15.2,15L14.9,15.6C14.9,15.6 14.6,15.9 14.4,15.9 14.2,15.9 14,16 13.8,16 13.6,16 13.4,16 13.2,15.9 13,15.8 12.9,15.7 12.7,15.6 12.5,15.5 12.5,15.3 12.4,15 12.3,14.7 12.3,14.5 12.3,14.2L12.3,13.5C12.3,13.2,12.3,12.9,12.4,12.7L12.7,12.1C12.7,12.1 13,11.8 13.2,11.8 13.4,11.8 13.6,11.7 13.8,11.7 14,11.7 14.2,11.7 14.4,11.8 14.6,11.9 14.7,12 14.9,12.1 15.1,12.2 15.1,12.4 15.2,12.7 15.3,13 15.3,13.2 15.3,13.5L15.3,14.2z M14.5,13.4L14.5,12.9C14.5,12.8 14.4,12.7 14.4,12.6 14.4,12.5 14.3,12.5 14.2,12.4 14.1,12.3 14,12.3 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.4L13.4,12.6C13.4,12.6,13.3,12.8,13.3,12.9L13.3,14.9C13.3,14.9 13.4,15.1 13.4,15.2 13.4,15.3 13.5,15.3 13.6,15.4 13.7,15.5 13.8,15.5 13.9,15.5 14,15.5 14.1,15.5 14.2,15.4L14.4,15.2C14.4,15.2,14.5,15,14.5,14.9L14.5,13.4z"));
            Icons.Add(new IconModel("Skip Next", "F1 M24,24z M0,0z M6,18L14.5,12 6,6 6,18z M16,6L16,18 18,18 18,6 16,6z"));
            Icons.Add(new IconModel("Skip Previous", "F1 M24,24z M0,0z M6,6L8,6 8,18 6,18z M9.5,12L18,18 18,6z"));
            Icons.Add(new IconModel("Rotate Left", "F1 M24,24z M0,0z M7.11,8.53L5.7,7.11C4.8,8.27,4.24,9.61,4.07,11L6.09,11C6.23,10.13,6.58,9.28,7.11,8.53z M6.09,13L4.07,13C4.24,14.39,4.79,15.73,5.69,16.89L7.1,15.47C6.58,14.72,6.23,13.88,6.09,13z M7.1,18.32C8.26,19.22,9.61,19.76,11,19.93L11,17.9C10.13,17.75,9.29,17.41,8.54,16.87L7.1,18.32z M13,4.07L13,1 8.45,5.55 13,10 13,6.09C15.84,6.57 18,9.03 18,12 18,14.97 15.84,17.43 13,17.91L13,19.93C16.95,19.44 20,16.08 20,12 20,7.92 16.95,4.56 13,4.07z"));
            Icons.Add(new IconModel("Rotate Right", "F1 M24,24z M0,0z M15.55,5.55L11,1 11,4.07C7.06,4.56 4,7.92 4,12 4,16.08 7.05,19.44 11,19.93L11,17.91C8.16,17.43 6,14.97 6,12 6,9.03 8.16,6.57 11,6.09L11,10 15.55,5.55z M19.93,11C19.76,9.61,19.21,8.27,18.31,7.11L16.89,8.53C17.43,9.28,17.77,10.13,17.91,11L19.93,11z M13,17.9L13,19.92C14.39,19.75,15.74,19.21,16.9,18.31L15.46,16.87C14.71,17.41,13.87,17.76,13,17.9z M16.89,15.48L18.31,16.89C19.21,15.73,19.76,14.39,19.93,13L17.91,13C17.77,13.87,17.43,14.72,16.89,15.48z"));
            Icons.Add(new IconModel("Clear", "F1 M24,24z M0,0z M19,6.41L17.59,5 12,10.59 6.41,5 5,6.41 10.59,12 5,17.59 6.41,19 12,13.41 17.59,19 19,17.59 13.41,12z"));
        }

        private void GetSelectedIcon()
        {
            SelectedIcon = Icons[_selectedIndex];
        }

        public ObservableCollection<IconModel> Icons
        {
            get { return _icons; }
            set { _icons = value; }
        }

        public IconModel SelectedIcon
        {
            get { return _selectedIcon; }
            set
            {
                _selectedIcon = value;
                OnPropertyChanged();
            }
        }

        public bool FillIcon
        {
            get { return _fillIcon; }
            set
            {
                _fillIcon = value;
                OnPropertyChanged();
            }
        }

        public ICommand BackCommand { get; private set; }
        public ICommand NextCommand { get; private set; }

        public void InitCommands()
        {
            BackCommand = new RelayCommand(ExecuteBackPageCommand, CanExecuteBackPageCommand);
            NextCommand = new RelayCommand(ExecuteNextPageCommand, CanExecuteNextPageCommand);
        }

        public bool CanExecuteBackPageCommand()
        {
            return true;
        }

        public void ExecuteBackPageCommand()
        {
            _selectedIndex--;

            if (_selectedIndex < 0)
                _selectedIndex = Icons.Count-1;

            GetSelectedIcon();
        }

        public bool CanExecuteNextPageCommand()
        {
            return true;
        }

        public void ExecuteNextPageCommand()
        {
            _selectedIndex++;

            if (_selectedIndex > Icons.Count - 1)
                _selectedIndex = 0;

            GetSelectedIcon();
        }
    }
}
