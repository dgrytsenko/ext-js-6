/**
 * This class is the controller for the main view for the application. It is specified as
 * the "controller" of the Main view class.
 *
 * TODO - Replace this content of this view to suite the needs of your application.
 */
Ext.define('MyApp602.view.main.MainController', {
    extend: 'Ext.app.ViewController',

    alias: 'controller.main',

    onItemSelected: function (sender, record) {
        Ext.Msg.confirm('Confirm', 'Are you sure?', 'onConfirm', this);
    },

    onTabChanged: function (sender, oldTab, newTag) {
        // let store = Ext.getStore('store.personnel');
        // store.load();
    },

    onConfirm: function (choice) {
        if (choice === 'yes') {
            console.log('yes');
        }
    }
});
