using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MailSender.Controls
{

    public partial class ListController : UserControl
    {
        #region Items Property
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register
            (
                "Items",
                typeof(IEnumerable),
                typeof(ListController),
                new PropertyMetadata(default(IEnumerable), OnItemsChanged, ItemsCoreceValue),
                ItemsValidate);

        private static bool ItemsValidate(object value)
        {
            return true;
        }

        private static object ItemsCoreceValue(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        private static void OnItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        public IEnumerable Items
        {
            get => (IEnumerable)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);

        }
        #endregion

        #region SelectedItem: object - Выбранный элемент


        public object SelectedItem
        {
            get => (object)GetValue(SelectedItemProperty); 
            set => SetValue(SelectedItemProperty, value); 
        }

      
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register
            (
                nameof(SelectedItem), 
                typeof(object), 
                typeof(ListController), 
                new PropertyMetadata(default(object)));


        #endregion

        #region  PanelName: String - Название панели


        public string PanelName
        {
            get => (string)GetValue(PanelNameProperty); 
            set => SetValue(PanelNameProperty, value); 
        }

        
        public static readonly DependencyProperty PanelNameProperty =
            DependencyProperty.Register
            (
                nameof(PanelName), 
                typeof(string), 
                typeof(ListController), 
                new PropertyMetadata(default(string)));





        #endregion

        #region SelectedItemIndex: int - Индекс выбранного элемента


        public int SelectedItemIndex
        {
            get => (int)GetValue(SelectedItemIndexProperty); 
            set => SetValue(SelectedItemIndexProperty, value);
        }

        // Using a DependencyProperty as the backing store for SelectedItemIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemIndexProperty =
            DependencyProperty.Register
            (
                nameof(SelectedItemIndex), 
                typeof(int), 
                typeof(ListController), 
                new PropertyMetadata(default(int)));

        #endregion

        #region ViewPropertyPath: string - Имя отображаемого свойства


        public string ViewPropertyPath
        {
            get =>  (string)GetValue(ViewPropertyPathProperty); 
            set => SetValue(ViewPropertyPathProperty, value); 
        }

       
        public static readonly DependencyProperty ViewPropertyPathProperty =
            DependencyProperty.Register
            (
                nameof(ViewPropertyPath), 
                typeof(string), 
                typeof(ListController), 
                new PropertyMetadata(default(string)));



        #endregion

        #region ValuePropertyPath: string - Имя свойства значения


        public string ValuePropertyPath
        {
            get =>  (string)GetValue(ValuePropertyPathProperty); 
            set => SetValue(ValuePropertyPathProperty, value); 
        }

        // Using a DependencyProperty as the backing store for ValuePropertyPath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValuePropertyPathProperty =
            DependencyProperty.Register
            (
                nameof(ValuePropertyPath), 
                typeof(string), 
                typeof(ListController), 
                new PropertyMetadata(default(string)));


        #endregion

        #region ItemTemplate: DataTemplate -Шаблон визуальных данных


        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty); 
            set => SetValue(ItemTemplateProperty, value); 
        }


        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register
            (
                nameof(ItemTemplate), 
                typeof(DataTemplate), 
                typeof(ListController), 
                new PropertyMetadata(default(DataTemplate)));


        #endregion

        #region CreateCommand: ICommand - Команда создания



        public ICommand CreateCommand
        {
            get => (ICommand)GetValue(CreateCommandProperty);
            set => SetValue(CreateCommandProperty, value); 
        }

    
        public static readonly DependencyProperty CreateCommandProperty =
            DependencyProperty.Register
            (
                nameof(CreateCommand), 
                typeof(ICommand), 
                typeof(ListController), 
                new PropertyMetadata(default(ICommand)));



        #endregion

        #region EditCommand: ICommand - Команда редактирования


        public ICommand EditCommand
        {
            get => (ICommand)GetValue(EditCommandProperty); 
            set => SetValue(EditCommandProperty, value); 
        }

        
        public static readonly DependencyProperty EditCommandProperty =
            DependencyProperty.Register
            (
                nameof(EditCommand), 
                typeof(ICommand), 
                typeof(ListController), 
                new PropertyMetadata(default(ICommand)));



        #endregion

        #region DeleteCommand: ICommand - Команда удаления


        public ICommand DeleteCommand
        {
            get => (ICommand)GetValue(DeleteCommandProperty); 
            set => SetValue(DeleteCommandProperty, value); 
        }


        public static readonly DependencyProperty DeleteCommandProperty =
            DependencyProperty.Register
            (
                nameof(DeleteCommand), 
                typeof(ICommand), 
                typeof(ListController), 
                new PropertyMetadata(default(ICommand)));


        #endregion


        public ListController() => InitializeComponent();

    }
}
