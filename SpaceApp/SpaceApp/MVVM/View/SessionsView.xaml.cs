using SpaceApp.MVVM.ViewModel;
using SpaceApp.MVVM.Model;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace SpaceApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for SessionsView.xaml
    /// </summary>
    public partial class SessionsView : UserControl
    {
        private Point _dragStartPoint;
        private SessionModel _draggedData;
        public SessionsView()
        {
            InitializeComponent();
        }

        private void OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // store mouse position
            _dragStartPoint = e.GetPosition(null);
        }

        private void OnPreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point mousePos = e.GetPosition(null);
                Vector diff = _dragStartPoint - mousePos;

                // Start dragging if the mouse has moved far enough
                if (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    var item = FindAncestor<ContentPresenter>((DependencyObject)e.OriginalSource);
                    if (item != null)
                    {
                        _draggedData = item.Content as SessionModel;
                        if (_draggedData != null)
                        {
                            // Start the drag operation
                            DragDrop.DoDragDrop(item, _draggedData, DragDropEffects.Move);
                        }
                    }
                }
            }
        }

        private void OnDrop(object sender, DragEventArgs e)
        {
            if (_draggedData == null)
                return;

            var droppedData = e.Data.GetData(_draggedData.GetType()) as SessionModel;
            var target = ((FrameworkElement)sender).DataContext as SessionModel;

            var sessions = DataContext as SessionsViewModel;
            int indexRemove = sessions.Sessions.IndexOf(_draggedData);
            int indexInsert = sessions.Sessions.IndexOf(target);

            if (indexRemove != indexInsert)
            {
                sessions.Sessions.RemoveAt(indexRemove);
                sessions.Sessions.Insert(indexInsert, droppedData);
            }

            _draggedData = null;
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(_draggedData.GetType()) || sender == _draggedData)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void OnDragLeave(object sender, DragEventArgs e)
        {
            // Optional: Handle visual feedback on drag leave
        }

        // Utility method to find the ancestor of a specific type
        private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            while (current != null)
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            return null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SessionDataEntryView window = new SessionDataEntryView();
            window.Owner = Window.GetWindow(this);
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Show();
        }
    }
}
