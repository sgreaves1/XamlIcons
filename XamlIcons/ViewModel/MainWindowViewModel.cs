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
            FillIcon = true;

            GetIcons();

            _selectedIndex = 0;

            GetSelectedIcon();

            InitCommands();
        }

        private void GetIcons()
        {
            // Google Material Icons
            Icons.Add(new IconModel("Google Material Icons", "3D Rotation", "F1 M24,24z M0,0z M7.52,21.48C4.25,19.94,1.91,16.76,1.55,13L0.05,13C0.56,19.16,5.71,24,12,24L12.66,23.97 8.85,20.16 7.52,21.48z M8.41,14.96C8.22,14.96 8.04,14.93 7.89,14.88 7.73,14.82 7.6,14.75 7.49,14.64 7.38,14.54 7.29,14.42 7.23,14.27 7.17,14.13 7.14,13.97 7.14,13.8L5.84,13.8C5.84,14.16 5.91,14.48 6.05,14.75 6.19,15.02 6.38,15.25 6.61,15.44 6.85,15.62 7.12,15.76 7.43,15.85 7.73,15.95 8.05,16 8.39,16 8.76,16 9.11,15.95 9.42,15.85 9.74,15.75 10.02,15.6 10.25,15.41 10.48,15.22 10.67,14.98 10.8,14.69 10.93,14.4 11,14.08 11,13.72 11,13.53 10.98,13.34 10.93,13.16 10.88,12.98 10.81,12.81 10.7,12.65 10.6,12.49 10.46,12.35 10.3,12.22 10.13,12.09 9.93,11.99 9.69,11.91 9.89,11.82 10.06,11.71 10.21,11.58 10.36,11.45 10.48,11.31 10.58,11.16 10.68,11.01 10.75,10.86 10.8,10.7 10.85,10.54 10.87,10.38 10.87,10.22 10.87,9.86 10.81,9.54 10.69,9.26 10.57,8.98 10.4,8.75 10.18,8.57 9.98,8.38 9.71,8.24 9.41,8.14 9.1,8.05 8.76,8 8.39,8 8.03,8 7.7,8.05 7.39,8.16 7.09,8.27 6.82,8.42 6.6,8.61 6.39,8.8 6.22,9.02 6.09,9.28 5.97,9.54 5.91,9.82 5.91,10.13L7.21,10.13C7.21,9.96 7.24,9.81 7.3,9.68 7.36,9.55 7.44,9.43 7.55,9.34 7.66,9.25 7.78,9.17 7.93,9.12 8.08,9.07 8.23,9.04 8.41,9.04 8.81,9.04 9.11,9.14 9.3,9.35 9.49,9.55 9.59,9.84 9.59,10.21 9.59,10.39 9.56,10.55 9.51,10.7 9.46,10.85 9.37,10.97 9.26,11.07 9.15,11.17 9.01,11.25 8.85,11.31 8.69,11.37 8.49,11.4 8.27,11.4L7.5,11.4 7.5,12.43 8.27,12.43C8.49,12.43 8.69,12.45 8.87,12.5 9.05,12.55 9.2,12.63 9.32,12.73 9.44,12.84 9.54,12.97 9.61,13.13 9.68,13.29 9.71,13.48 9.71,13.7 9.71,14.11 9.59,14.42 9.36,14.63 9.13,14.86 8.81,14.96 8.41,14.96z M16.96,9.04C16.64,8.71 16.26,8.45 15.82,8.27 15.39,8.09 14.9,8 14.36,8L12,8 12,16 14.3,16C14.85,16 15.36,15.91 15.81,15.73 16.26,15.55 16.65,15.3 16.97,14.97 17.29,14.64 17.54,14.24 17.71,13.78 17.88,13.31 17.97,12.79 17.97,12.21L17.97,11.81C17.97,11.23 17.88,10.71 17.71,10.24 17.53,9.77 17.28,9.37 16.96,9.04z M16.57,12.2C16.57,12.62 16.52,12.99 16.43,13.33 16.33,13.66 16.19,13.95 16,14.18 15.81,14.41 15.57,14.59 15.29,14.71 15,14.83 14.67,14.89 14.3,14.89L13.39,14.89 13.39,9.12 14.36,9.12C15.08,9.12 15.63,9.35 16,9.81 16.38,10.27 16.57,10.93 16.57,11.8L16.57,12.2z M12,0L11.34,0.03 15.15,3.84 16.48,2.51C19.75,4.06,22.09,7.23,22.44,10.99L23.94,10.99C23.44,4.84,18.29,0,12,0z"));
            Icons.Add(new IconModel("Google Material Icons", "Accessibility", "F1 M24,24z M0,0z M12,2C13.1,2 14,2.9 14,4 14,5.1 13.1,6 12,6 10.9,6 10,5.1 10,4 10,2.9 10.9,2 12,2z M21,9L15,9 15,22 13,22 13,16 11,16 11,22 9,22 9,9 3,9 3,7 21,7 21,9z"));
            Icons.Add(new IconModel("Google Material Icons", "Accessible", "F1 M24,24z M0,0z M19,13L19,11C17.46,11.02,15.91,10.25,14.93,9.17L13.64,7.74C13.47,7.55 13.26,7.4 13.03,7.29 13.02,7.29 13.02,7.28 13.01,7.28L13,7.28C12.65,7.08 12.25,6.98 11.81,7.02 10.76,7.11 10,8.04 10,9.09L10,15C10,16.1,10.9,17,12,17L17,17 17,22 19,22 19,16.5C19,15.4,18.1,14.5,17,14.5L14,14.5 14,11.05C15.29,12.12,17.25,12.99,19,13z M12.83,18C12.42,19.16 11.31,20 10,20 8.34,20 7,18.66 7,17 7,15.69 7.84,14.59 9,14.17L9,12.1C6.72,12.56 5,14.58 5,17 5,19.76 7.24,22 10,22 12.42,22 14.44,20.28 14.9,18L12.83,18z"));
            Icons.Add(new IconModel("Google Material Icons", "Account Balance", "F1 M24,24z M0,0z M4,10L4,17 7,17 7,10 4,10z M10,10L10,17 13,17 13,10 10,10z M2,22L21,22 21,19 2,19 2,22z M16,10L16,17 19,17 19,10 16,10z M11.5,1L2,6 2,8 21,8 21,6 11.5,1z"));
            Icons.Add(new IconModel("Google Material Icons", "Add", "F1 M24,24z M0,0z M19,13L13,13 13,19 11,19 11,13 5,13 5,11 11,11 11,5 13,5 13,11 19,11 19,13z"));
            Icons.Add(new IconModel("Google Material Icons", "Arrow Downward", "F1 M24,24z M0,0z M20,12L18.59,10.59 13,16.17 13,4 11,4 11,16.17 5.42,10.58 4,12 12,20 20,12z"));
            Icons.Add(new IconModel("Google Material Icons", "Arrow Upward", "F1 M24,24z M0,0z M4,12L5.41,13.41 11,7.83 11,20 13,20 13,7.83 18.58,13.42 20,12 12,4 4,12z"));
            Icons.Add(new IconModel("Google Material Icons", "Attach File", "F1 M24,24z M0,0z M16.5,6L16.5,17.5C16.5,19.71 14.71,21.5 12.5,21.5 10.29,21.5 8.5,19.71 8.5,17.5L8.5,5C8.5,3.62 9.62,2.5 11,2.5 12.38,2.5 13.5,3.62 13.5,5L13.5,15.5C13.5,16.05 13.05,16.5 12.5,16.5 11.95,16.5 11.5,16.05 11.5,15.5L11.5,6 10,6 10,15.5C10,16.88 11.12,18 12.5,18 13.88,18 15,16.88 15,15.5L15,5C15,2.79 13.21,1 11,1 8.79,1 7,2.79 7,5L7,17.5C7,20.54 9.46,23 12.5,23 15.54,23 18,20.54 18,17.5L18,6 16.5,6z"));
            Icons.Add(new IconModel("Google Material Icons", "Attach Money", "F1 M24,24z M0,0z M11.8,10.9C9.53,10.31 8.8,9.7 8.8,8.75 8.8,7.66 9.81,6.9 11.5,6.9 13.28,6.9 13.94,7.75 14,9L16.21,9C16.14,7.28,15.09,5.7,13,5.19L13,3 10,3 10,5.16C8.06,5.58 6.5,6.84 6.5,8.77 6.5,11.08 8.41,12.23 11.2,12.9 13.7,13.5 14.2,14.38 14.2,15.31 14.2,16 13.71,17.1 11.5,17.1 9.44,17.1 8.63,16.18 8.52,15L6.32,15C6.44,17.19,8.08,18.42,10,18.83L10,21 13,21 13,18.85C14.95,18.48 16.5,17.35 16.5,15.3 16.5,12.46 14.07,11.49 11.8,10.9z"));
            Icons.Add(new IconModel("Google Material Icons", "Clear", "F1 M24,24z M0,0z M19,6.41L17.59,5 12,10.59 6.41,5 5,6.41 10.59,12 5,17.59 6.41,19 12,13.41 17.59,19 19,17.59 13.41,12z"));
            Icons.Add(new IconModel("Google Material Icons", "Code", "F1 M24,24z M0,0z M9.4,16.6L4.8,12 9.4,7.4 8,6 2,12 8,18 9.4,16.6z M14.6,16.6L19.2,12 14.6,7.4 16,6 22,12 16,18 14.6,16.6z"));
            Icons.Add(new IconModel("Google Material Icons", "Delete", "F1 M24,24z M0,0z M6,19C6,20.1,6.9,21,8,21L16,21C17.1,21,18,20.1,18,19L18,7 6,7 6,19z M19,4L15.5,4 14.5,3 9.5,3 8.5,4 5,4 5,6 19,6 19,4z"));
            Icons.Add(new IconModel("Google Material Icons", "Delete Forever", "F1 M24,24z M0,0z M6,19C6,20.1,6.9,21,8,21L16,21C17.1,21,18,20.1,18,19L18,7 6,7 6,19z M8.46,11.88L9.87,10.47 12,12.59 14.12,10.47 15.53,11.88 13.41,14 15.53,16.12 14.12,17.53 12,15.41 9.88,17.53 8.47,16.12 10.59,14 8.46,11.88z M15.5,4L14.5,3 9.5,3 8.5,4 5,4 5,6 19,6 19,4z"));
            Icons.Add(new IconModel("Google Material Icons", "Eject", "F1 M24,24z M0,0z M5,17L19,17 19,19 5,19z M12,5L5.33,15 18.67,15z"));
            Icons.Add(new IconModel("Google Material Icons", "Fast Forward", "F1 M24,24z M0,0z M4,18L12.5,12 4,6 4,18z M13,6L13,18 21.5,12 13,6z"));
            Icons.Add(new IconModel("Google Material Icons", "Fast Rewind", "F1 M24,24z M0,0z M11,18L11,6 2.5,12 11,18z M11.5,12L20,18 20,6 11.5,12z"));
            Icons.Add(new IconModel("Google Material Icons", "Fingerprint", "F1 M24,24z M0,0z M17.81,4.47C17.73,4.47 17.65,4.45 17.58,4.41 15.66,3.42 14,3 12.01,3 10.03,3 8.15,3.47 6.44,4.41 6.2,4.54 5.9,4.45 5.76,4.21 5.63,3.97 5.72,3.66 5.96,3.53 7.82,2.52 9.86,2 12.01,2 14.14,2 16,2.47 18.04,3.52 18.29,3.65 18.38,3.95 18.25,4.19 18.16,4.37 17.99,4.47 17.81,4.47z M3.5,9.72C3.4,9.72 3.3,9.69 3.21,9.63 2.98,9.47 2.93,9.16 3.09,8.93 4.08,7.53 5.34,6.43 6.84,5.66 9.98,4.04 14,4.03 17.15,5.65 18.65,6.42 19.91,7.51 20.9,8.9 21.06,9.12 21.01,9.44 20.78,9.6 20.55,9.76 20.24,9.71 20.08,9.48 19.18,8.22 18.04,7.23 16.69,6.54 13.82,5.07 10.15,5.07 7.29,6.55 5.93,7.25 4.79,8.25 3.89,9.51 3.81,9.65 3.66,9.72 3.5,9.72z M9.75,21.79C9.62,21.79 9.49,21.74 9.4,21.64 8.53,20.77 8.06,20.21 7.39,19 6.7,17.77 6.34,16.27 6.34,14.66 6.34,11.69 8.88,9.27 12,9.27 15.12,9.27 17.66,11.69 17.66,14.66 17.66,14.94 17.44,15.16 17.16,15.16 16.88,15.16 16.66,14.94 16.66,14.66 16.66,12.24 14.57,10.27 12,10.27 9.43,10.27 7.34,12.24 7.34,14.66 7.34,16.1 7.66,17.43 8.27,18.51 8.91,19.66 9.35,20.15 10.12,20.93 10.31,21.13 10.31,21.44 10.12,21.64 10.01,21.74 9.88,21.79 9.75,21.79z M16.92,19.94C15.73,19.94 14.68,19.64 13.82,19.05 12.33,18.04 11.44,16.4 11.44,14.66 11.44,14.38 11.66,14.16 11.94,14.16 12.22,14.16 12.44,14.38 12.44,14.66 12.44,16.07 13.16,17.4 14.38,18.22 15.09,18.7 15.92,18.93 16.92,18.93 17.16,18.93 17.56,18.9 17.96,18.83 18.23,18.78 18.49,18.96 18.54,19.24 18.59,19.51 18.41,19.77 18.13,19.82 17.56,19.93 17.06,19.94 16.92,19.94z M14.91,22C14.87,22 14.82,21.99 14.78,21.98 13.19,21.54 12.15,20.95 11.06,19.88 9.66,18.49 8.89,16.64 8.89,14.66 8.89,13.04 10.27,11.72 11.97,11.72 13.67,11.72 15.05,13.04 15.05,14.66 15.05,15.73 15.98,16.6 17.13,16.6 18.28,16.6 19.21,15.73 19.21,14.66 19.21,10.89 15.96,7.83 11.96,7.83 9.12,7.83 6.52,9.41 5.35,11.86 4.96,12.67 4.76,13.62 4.76,14.66 4.76,15.44 4.83,16.67 5.43,18.27 5.53,18.53 5.4,18.82 5.14,18.91 4.88,19.01 4.59,18.87 4.5,18.62 4.01,17.31 3.77,16.01 3.77,14.66 3.77,13.46 4,12.37 4.45,11.42 5.78,8.63 8.73,6.82 11.96,6.82 16.51,6.82 20.21,10.33 20.21,14.65 20.21,16.27 18.83,17.59 17.13,17.59 15.43,17.59 14.05,16.27 14.05,14.65 14.05,13.58 13.12,12.71 11.97,12.71 10.82,12.71 9.89,13.58 9.89,14.65 9.89,16.36 10.55,17.96 11.76,19.16 12.71,20.1 13.62,20.62 15.03,21.01 15.3,21.08 15.45,21.36 15.38,21.62 15.33,21.85 15.12,22 14.91,22z"));
            Icons.Add(new IconModel("Google Material Icons", "Fullscreen", "F1 M24,24z M0,0z M7,14L5,14 5,19 10,19 10,17 7,17 7,14z M5,10L7,10 7,7 10,7 10,5 5,5 5,10z M17,17L14,17 14,19 19,19 19,14 17,14 17,17z M14,5L14,7 17,7 17,10 19,10 19,5 14,5z"));
            Icons.Add(new IconModel("Google Material Icons", "Keyboard Arrow Down", "F1 M24,24z M0,0z M7.41,7.84L12,12.42 16.59,7.84 18,9.25 12,15.25 6,9.25z"));
            Icons.Add(new IconModel("Google Material Icons", "Keyboard Arrow Up", "F1 M24,24z M0,0z M7.41,15.41L12,10.83 16.59,15.41 18,14 12,8 6,14z"));
            Icons.Add(new IconModel("Google Material Icons", "Swap horiz", "F1 M24,24z M0,0z M6.99,11L3,15 6.99,19 6.99,16 14,16 14,14 6.99,14 6.99,11z M21,9L17.01,5 17.01,8 10,8 10,10 17.01,10 17.01,13 21,9z"));
            Icons.Add(new IconModel("Google Material Icons", "Forward 5", "F1 M24,24z M0,0z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z M10.7,13.9L10.9,11.7 13.3,11.7 13.3,12.4 11.6,12.4 11.5,13.3C11.5,13.3 11.6,13.3 11.6,13.2 11.6,13.1 11.7,13.2 11.7,13.1 11.7,13 11.8,13.1 11.9,13.1L12.1,13.1C12.3,13.1 12.5,13.1 12.6,13.2 12.7,13.3 12.9,13.4 13,13.5 13.1,13.6 13.2,13.8 13.3,14 13.4,14.2 13.4,14.4 13.4,14.6 13.4,14.8 13.4,15 13.3,15.1 13.2,15.2 13.2,15.4 13,15.6 12.8,15.8 12.7,15.8 12.5,15.9 12.3,16 12.1,16 11.9,16 11.7,16 11.5,16 11.4,15.9 11.3,15.8 11.1,15.8 10.9,15.7 10.7,15.6 10.7,15.5 10.6,15.3 10.5,15.1 10.5,15 10.5,14.8L11.3,14.8C11.3,15 11.4,15.1 11.5,15.2 11.6,15.3 11.7,15.3 11.9,15.3 12,15.3 12.1,15.3 12.2,15.2L12.4,15C12.4,15,12.5,14.8,12.5,14.7L12.5,14.1 12.4,13.9 12.2,13.7C12.2,13.7,12,13.6,11.9,13.6L11.7,13.6C11.7,13.6 11.6,13.6 11.5,13.7 11.4,13.8 11.4,13.7 11.4,13.8 11.4,13.9 11.3,13.9 11.3,13.9L10.7,13.9z"));
            Icons.Add(new IconModel("Google Material Icons", "Forward 10", "F1 M24,24z M0,0z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z M10.8,16L10,16 10,12.7 9,13 9,12.3 10.8,11.7 10.9,11.7 10.9,16z M15.1,14.2C15.1,14.5,15.1,14.8,15,15L14.7,15.6C14.7,15.6 14.4,15.9 14.2,15.9 14,15.9 13.8,16 13.6,16 13.4,16 13.2,16 13,15.9 12.8,15.8 12.7,15.7 12.5,15.6 12.3,15.5 12.3,15.3 12.2,15 12.1,14.7 12.1,14.5 12.1,14.2L12.1,13.5C12.1,13.2,12.1,12.9,12.2,12.7L12.5,12.1C12.5,12.1 12.8,11.8 13,11.8 13.2,11.8 13.4,11.7 13.6,11.7 13.8,11.7 14,11.7 14.2,11.8 14.4,11.9 14.5,12 14.7,12.1 14.9,12.2 14.9,12.4 15,12.7 15.1,13 15.1,13.2 15.1,13.5L15.1,14.2z M14.3,13.4L14.3,12.9C14.3,12.9 14.2,12.7 14.2,12.6 14.2,12.5 14.1,12.5 14,12.4 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.3 13.5,12.3 13.4,12.4L13.2,12.6C13.2,12.6,13.1,12.8,13.1,12.9L13.1,14.9C13.1,14.9 13.2,15.1 13.2,15.2 13.2,15.3 13.3,15.3 13.4,15.4 13.5,15.5 13.6,15.5 13.7,15.5 13.8,15.5 13.9,15.5 14,15.4L14.2,15.2C14.2,15.2,14.3,15,14.3,14.9L14.3,13.4z"));
            Icons.Add(new IconModel("Google Material Icons", "Forward 30", "F1 M24,24z M0,0z M9.6,13.5L10,13.5C10.2,13.5 10.4,13.4 10.5,13.3 10.6,13.2 10.7,13.1 10.7,12.9L10.7,12.7C10.7,12.7 10.6,12.6 10.6,12.5 10.6,12.4 10.5,12.4 10.4,12.4L9.9,12.4C9.9,12.4 9.8,12.5 9.7,12.5 9.6,12.5 9.6,12.6 9.6,12.7L9.6,12.9 8.6,12.9C8.6,12.7 8.6,12.6 8.7,12.4 8.8,12.2 8.9,12.1 9,12 9.1,11.9 9.3,11.8 9.4,11.8 9.5,11.8 9.8,11.7 9.9,11.7 10.1,11.7 10.3,11.7 10.5,11.8 10.7,11.9 10.8,11.9 11,12 11.2,12.1 11.2,12.2 11.3,12.4 11.4,12.6 11.4,12.7 11.4,12.9L11.4,13.2C11.4,13.2 11.3,13.4 11.3,13.5 11.3,13.6 11.2,13.7 11.1,13.7 11,13.7 10.9,13.8 10.8,13.9 11,14 11.2,14.1 11.3,14.3 11.4,14.5 11.5,14.7 11.5,14.9 11.5,15.1 11.5,15.3 11.4,15.4 11.3,15.5 11.2,15.7 11.1,15.8 11,15.9 10.8,16 10.6,16 10.4,16 10.2,16.1 10,16.1 9.8,16.1 9.6,16.1 9.5,16 9.4,15.9 9.2,15.9 9,15.8 8.8,15.7 8.8,15.6 8.7,15.4 8.6,15.2 8.6,15 8.6,14.8L9.4,14.8 9.4,15C9.4,15 9.5,15.1 9.5,15.2 9.5,15.3 9.6,15.3 9.7,15.3L10.2,15.3C10.2,15.3 10.3,15.2 10.4,15.2 10.5,15.2 10.5,15.1 10.5,15L10.5,14.5C10.5,14.5 10.4,14.4 10.4,14.3 10.4,14.2 10.3,14.2 10.2,14.2L9.6,14.2 9.6,13.5z M15.3,14.2C15.3,14.5,15.3,14.8,15.2,15L14.9,15.6C14.9,15.6 14.6,15.9 14.4,15.9 14.2,15.9 14,16 13.8,16 13.6,16 13.4,16 13.2,15.9 13,15.8 12.9,15.7 12.7,15.6 12.5,15.5 12.5,15.3 12.4,15 12.3,14.7 12.3,14.5 12.3,14.2L12.3,13.5C12.3,13.2,12.3,12.9,12.4,12.7L12.7,12.1C12.7,12.1 13,11.8 13.2,11.8 13.4,11.8 13.6,11.7 13.8,11.7 14,11.7 14.2,11.7 14.4,11.8 14.6,11.9 14.7,12 14.9,12.1 15.1,12.2 15.1,12.4 15.2,12.7 15.3,13 15.3,13.2 15.3,13.5L15.3,14.2z M14.4,13.4L14.4,12.9C14.4,12.9 14.3,12.7 14.3,12.6 14.3,12.5 14.2,12.5 14.1,12.4 14,12.3 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.3 13.5,12.4L13.3,12.6C13.3,12.6,13.2,12.8,13.2,12.9L13.2,14.9C13.2,14.9 13.3,15.1 13.3,15.2 13.3,15.3 13.4,15.3 13.5,15.4 13.6,15.5 13.7,15.5 13.8,15.5 13.9,15.5 14,15.5 14.1,15.4L14.3,15.2C14.3,15.2,14.4,15,14.4,14.9L14.4,13.4z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z"));
            Icons.Add(new IconModel("Google Material Icons", "Pause", "F1 M24,24z M0,0z M6,19L10,19 10,5 6,5 6,19z M14,5L14,19 18,19 18,5 14,5z"));
            Icons.Add(new IconModel("Google Material Icons", "Play Arrow", "F1 M24,24z M0,0z M8,5L8,19 19,12z"));
            Icons.Add(new IconModel("Google Material Icons", "Replay", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.31,7 18,9.69 18,13 18,16.31 15.31,19 12,19 8.69,19 6,16.31 6,13L4,13C4,17.42 7.58,21 12,21 16.42,21 20,17.42 20,13 20,8.58 16.42,5 12,5z"));
            Icons.Add(new IconModel("Google Material Icons", "Replay 5", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.3,7 18,9.7 18,13 18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13L4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13 20,8.6 16.4,5 12,5z M10.7,13.9L10.9,11.7 13.3,11.7 13.3,12.4 11.6,12.4 11.5,13.3C11.5,13.3 11.6,13.3 11.6,13.2 11.6,13.1 11.7,13.2 11.7,13.1 11.7,13 11.8,13.1 11.9,13.1L12.1,13.1C12.3,13.1 12.5,13.1 12.6,13.2 12.7,13.3 12.9,13.4 13,13.5 13.1,13.6 13.2,13.8 13.3,14 13.4,14.2 13.4,14.4 13.4,14.6 13.4,14.8 13.4,15 13.3,15.1 13.2,15.2 13.2,15.4 13,15.6 12.8,15.8 12.7,15.8 12.6,15.9 12.5,16 12.2,16 12,16 11.8,16 11.6,16 11.5,15.9 11.4,15.8 11.2,15.8 11,15.7 10.8,15.6 10.8,15.5 10.7,15.3 10.6,15.1 10.6,15 10.6,14.8L11.4,14.8C11.4,15 11.5,15.1 11.6,15.2 11.7,15.3 11.8,15.3 12,15.3 12.1,15.3 12.2,15.3 12.3,15.2L12.5,15C12.5,15,12.6,14.8,12.6,14.7L12.6,14.1 12.5,13.9 12.3,13.7C12.3,13.7,12.1,13.6,12,13.6L11.8,13.6C11.8,13.6 11.7,13.6 11.6,13.7 11.5,13.8 11.5,13.7 11.5,13.8 11.5,13.9 11.4,13.9 11.4,13.9L10.7,13.9z"));
            Icons.Add(new IconModel("Google Material Icons", "Replay 10", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.3,7 18,9.7 18,13 18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13L4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13 20,8.6 16.4,5 12,5z M10.9,16L10,16 10,12.7 9,13 9,12.3 10.8,11.7 10.9,11.7 10.9,16z M15.2,14.2C15.2,14.5,15.2,14.8,15.1,15L14.8,15.6C14.8,15.6 14.5,15.9 14.3,15.9 14.1,15.9 13.9,16 13.7,16 13.5,16 13.3,16 13.1,15.9 12.9,15.8 12.8,15.7 12.6,15.6 12.4,15.5 12.4,15.3 12.3,15 12.2,14.7 12.2,14.5 12.2,14.2L12.2,13.5C12.2,13.2,12.2,12.9,12.3,12.7L12.6,12.1C12.6,12.1 12.9,11.8 13.1,11.8 13.3,11.8 13.5,11.7 13.7,11.7 13.9,11.7 14.1,11.7 14.3,11.8 14.5,11.9 14.6,12 14.8,12.1 15,12.2 15,12.4 15.1,12.7 15.2,13 15.2,13.2 15.2,13.5L15.2,14.2z M14.3,13.4L14.3,12.9C14.3,12.9 14.2,12.7 14.2,12.6 14.2,12.5 14.1,12.5 14,12.4 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.3 13.5,12.3 13.4,12.4L13.2,12.6C13.2,12.6,13.1,12.8,13.1,12.9L13.1,14.9C13.1,14.9 13.2,15.1 13.2,15.2 13.2,15.3 13.3,15.3 13.4,15.4 13.5,15.5 13.6,15.5 13.7,15.5 13.8,15.5 13.9,15.5 14,15.4L14.2,15.2C14.2,15.2,14.3,15,14.3,14.9L14.3,13.4z"));
            Icons.Add(new IconModel("Google Material Icons", "Replay 30", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.3,7 18,9.7 18,13 18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13L4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13 20,8.6 16.4,5 12,5z M9.6,13.5L10,13.5C10.2,13.5 10.4,13.4 10.5,13.3 10.6,13.2 10.7,13.1 10.7,12.9L10.7,12.7C10.7,12.7 10.6,12.6 10.6,12.5 10.6,12.4 10.5,12.4 10.4,12.4L9.9,12.4C9.9,12.4 9.8,12.5 9.7,12.5 9.6,12.5 9.6,12.6 9.6,12.7L9.6,12.9 8.6,12.9C8.6,12.7 8.6,12.6 8.7,12.4 8.8,12.2 8.9,12.1 9,12 9.1,11.9 9.3,11.8 9.4,11.8 9.5,11.8 9.8,11.7 9.9,11.7 10.1,11.7 10.3,11.7 10.5,11.8 10.7,11.9 10.8,11.9 11,12 11.2,12.1 11.2,12.2 11.3,12.4 11.4,12.6 11.4,12.7 11.4,12.9L11.4,13.2C11.4,13.2 11.3,13.4 11.3,13.5 11.3,13.6 11.2,13.7 11.1,13.7 11,13.7 10.9,13.8 10.8,13.9 11,14 11.2,14.1 11.3,14.3 11.4,14.5 11.5,14.7 11.5,14.9 11.5,15.1 11.5,15.3 11.4,15.4 11.3,15.5 11.2,15.7 11.1,15.8 11,15.9 10.8,16 10.6,16 10.4,16 10.2,16.1 10,16.1 9.8,16.1 9.6,16.1 9.5,16 9.4,15.9 9.2,15.9 9,15.8 8.8,15.7 8.8,15.6 8.7,15.4 8.6,15.2 8.6,15 8.6,14.8L9.4,14.8 9.4,15C9.4,15 9.5,15.1 9.5,15.2 9.5,15.3 9.6,15.3 9.7,15.3L10.2,15.3C10.2,15.3 10.3,15.2 10.4,15.2 10.5,15.2 10.5,15.1 10.5,15L10.5,14.5C10.5,14.5 10.4,14.4 10.4,14.3 10.4,14.2 10.3,14.2 10.2,14.2L9.6,14.2 9.6,13.5z M15.3,14.2C15.3,14.5,15.3,14.8,15.2,15L14.9,15.6C14.9,15.6 14.6,15.9 14.4,15.9 14.2,15.9 14,16 13.8,16 13.6,16 13.4,16 13.2,15.9 13,15.8 12.9,15.7 12.7,15.6 12.5,15.5 12.5,15.3 12.4,15 12.3,14.7 12.3,14.5 12.3,14.2L12.3,13.5C12.3,13.2,12.3,12.9,12.4,12.7L12.7,12.1C12.7,12.1 13,11.8 13.2,11.8 13.4,11.8 13.6,11.7 13.8,11.7 14,11.7 14.2,11.7 14.4,11.8 14.6,11.9 14.7,12 14.9,12.1 15.1,12.2 15.1,12.4 15.2,12.7 15.3,13 15.3,13.2 15.3,13.5L15.3,14.2z M14.5,13.4L14.5,12.9C14.5,12.8 14.4,12.7 14.4,12.6 14.4,12.5 14.3,12.5 14.2,12.4 14.1,12.3 14,12.3 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.4L13.4,12.6C13.4,12.6,13.3,12.8,13.3,12.9L13.3,14.9C13.3,14.9 13.4,15.1 13.4,15.2 13.4,15.3 13.5,15.3 13.6,15.4 13.7,15.5 13.8,15.5 13.9,15.5 14,15.5 14.1,15.5 14.2,15.4L14.4,15.2C14.4,15.2,14.5,15,14.5,14.9L14.5,13.4z"));
            Icons.Add(new IconModel("Google Material Icons", "Skip Next", "F1 M24,24z M0,0z M6,18L14.5,12 6,6 6,18z M16,6L16,18 18,18 18,6 16,6z"));
            Icons.Add(new IconModel("Google Material Icons", "Skip Previous", "F1 M24,24z M0,0z M6,6L8,6 8,18 6,18z M9.5,12L18,18 18,6z"));
            Icons.Add(new IconModel("Google Material Icons", "Stop", "F1 M24,24z M0,0z M6,6L18,6 18,18 6,18z"));
            Icons.Add(new IconModel("Google Material Icons", "Rotate Left", "F1 M24,24z M0,0z M7.11,8.53L5.7,7.11C4.8,8.27,4.24,9.61,4.07,11L6.09,11C6.23,10.13,6.58,9.28,7.11,8.53z M6.09,13L4.07,13C4.24,14.39,4.79,15.73,5.69,16.89L7.1,15.47C6.58,14.72,6.23,13.88,6.09,13z M7.1,18.32C8.26,19.22,9.61,19.76,11,19.93L11,17.9C10.13,17.75,9.29,17.41,8.54,16.87L7.1,18.32z M13,4.07L13,1 8.45,5.55 13,10 13,6.09C15.84,6.57 18,9.03 18,12 18,14.97 15.84,17.43 13,17.91L13,19.93C16.95,19.44 20,16.08 20,12 20,7.92 16.95,4.56 13,4.07z"));
            Icons.Add(new IconModel("Google Material Icons", "Rotate Right", "F1 M24,24z M0,0z M15.55,5.55L11,1 11,4.07C7.06,4.56 4,7.92 4,12 4,16.08 7.05,19.44 11,19.93L11,17.91C8.16,17.43 6,14.97 6,12 6,9.03 8.16,6.57 11,6.09L11,10 15.55,5.55z M19.93,11C19.76,9.61,19.21,8.27,18.31,7.11L16.89,8.53C17.43,9.28,17.77,10.13,17.91,11L19.93,11z M13,17.9L13,19.92C14.39,19.75,15.74,19.21,16.9,18.31L15.46,16.87C14.71,17.41,13.87,17.76,13,17.9z M16.89,15.48L18.31,16.89C19.21,15.73,19.76,14.39,19.93,13L17.91,13C17.77,13.87,17.43,14.72,16.89,15.48z"));
        
            // LinearIcons
            Icons.Add(new IconModel("https://linearicons.com", "inr-bubble", "F1 M20,20z M0,0z M0.5,19C0.275,19 0.078,18.85 0.018,18.633 -0.042,18.416 0.05,18.186 0.243,18.071 1.934,17.057 2.635,15.582 2.884,14.892 1.046,13.485 0,11.538 0,9.5 0,8.471 0.258,7.474 0.768,6.536 1.254,5.642 1.948,4.841 2.829,4.155 4.616,2.765 6.985,1.999 9.5,1.999 12.015,1.999 14.384,2.765 16.171,4.155 17.052,4.84 17.746,5.641 18.232,6.536 18.742,7.473 19,8.47 19,9.5 19,10.53 18.742,11.526 18.232,12.464 17.746,13.358 17.052,14.159 16.171,14.845 14.384,16.235 12.015,17.001 9.5,17.001 8.467,17.001 7.453,16.872 6.484,16.616 6.055,16.902 5.253,17.409 4.295,17.886 2.807,18.626 1.531,19.001 0.501,19.001z M9.5,3C4.813,3 1,5.916 1,9.5 1,11.315 2.005,13.062 3.756,14.292 3.928,14.413 4.006,14.628 3.952,14.831 3.835,15.267 3.437,16.464 2.372,17.619 3.674,17.163 5.076,16.372 6.111,15.66 6.234,15.575 6.388,15.55 6.532,15.591 7.48,15.862 8.479,16 9.5,16 14.187,16 18,13.084 18,9.5 18,5.916 14.187,3 9.5,3z"));

            // Sam Greaves
            Icons.Add(new IconModel("Sam Greaves", "Reverse Flick", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7 C15.31,7 18,9.69 18,13 18,16.31 15.31,19 12,19 8.69,19 6,16.31 6,13 L6,13 C4,17.42 7.58,21 12,21 16.42,21 20,17.42 20,13 20,8.58 16.42,5 12,5z"));
            Icons.Add(new IconModel("Sam Greaves", "Reverse Flicked", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.31,7 18,9.69 18,13 18,16.31 15.31,19 12,19 8.69,19 6,16.31 2,16 L0,16 C4,17.42 7.58,21 12,21 16.42,21 20,17.42 20,13 20,8.58 16.42,5 12,5z"));
            Icons.Add(new IconModel("Sam Greaves", "Reverse Lick", "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.31,7 18,9.69 18,13 18,16.31 15.31,19 12,19 8.69,19 6,16.31 3,19 L3,19 C4,17.42 7.58,21 12,21 16.42,21 20,17.42 20,13 20,8.58 16.42,5 12,5z"));


            
            // Unknown
            Icons.Add(new IconModel("Unknown", "Running Man", "M297.290,51.396 C262.000,50.999 246.954,83.495 261.290,124.396 L258.5,132.5 229,124 162,145.5 C152.854,152.268 150.539,159.446 154.5,167 L174,223 C185.691,236.661 193.877,234.414 198.5,216 L182,168.5 224,154.5 228.5,170.5 220,226 167.5,279.5 114,254.5 96.5,256 75.5,292.5 C78.181,308.041 85.564,312.972 98,306.5 L112,281.5 156,304 C165.007,311.500 172.673,311.331 179,303.5 L213,268.5 230.5,263.5 255,269 311,297 304,340.5 C301.959,349.296 303.918,355.654 310,359.5 L336,376.5 C352.586,380.964 356.915,374.496 350,358 L332,343.5 337,297 C338.268,286.908 333.850,279.974 325,275.5 L277.5,250 295.5,191 303.5,200 316.5,234.5 C323.303,246.152 331.801,248.497 342,241.5 L390,206 C397.694,190.695 392.958,184.365 376.5,186.5 L337,213 318.5,167 310.5,157.5 287.5,146.5 286,135 C333.000,124.000 333.500,68.499 297.290,51.396 z"));
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
