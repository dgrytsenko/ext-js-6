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
        //Ext.Msg.confirm('Confirm', 'Are you sure?', 'onConfirm', this);

        // restApiCall('personell', {id: record.id}).then(function (data) {
        //     openWindow(data);
        // });

        Ext.Ajax.request({
            url: 'http://localhost:60362/api/personell',
            method: 'GET',
            timeout: 60000,
            params:
                {
                    id: record.data.id
                },
            headers:
                {
                    'Content-Type': 'application/json'
                },
            success: function (response) {
                let personWindow = Ext.widget('person.window');
                personWindow.show();
                personWindow.loadData(response);
                console.log('done');
            },
            failure: function (response) {
                Ext.Msg.alert('Status', 'Request Failed.');
            }
        });


    },

    onTabChanged: function (sender, oldTab, newTab) {
        console.log('tab changed: ' + newTab)
        let store = Ext.getStore('store.personnel');
        store.load();
    },

    onConfirm: function (choice) {
        if (choice === 'yes') {
            console.log('yes');
        }
    }
});
