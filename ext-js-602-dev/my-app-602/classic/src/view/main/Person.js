/**
 * This view is an example list of people.
 */
Ext.define('MyApp602.view.main.Person', {
    extend: 'Ext.window.Window',
    xtype: 'person.window',
    reference: 'personWindow',
    requires: ['MyApp602.view.main.MainController'],
    controller: 'main',
    title: 'Hello',
    height: 200,
    width: 400,
    layout: 'fit',
    items: {  // Let's put an empty grid in just to illustrate fit layout
        xtype: 'grid',
        border: false,
        columns: [{header: 'World'}],                 // One header just for show. There's no data,
        store: Ext.create('Ext.data.ArrayStore', {}) // A dummy empty data store
    },
    buttons: [
        {
            xtype: 'button',
            text: 'OK',
            itemId: 'okPersonWindowButton'
        },
        {
            xtype: 'button',
            text: 'Cancel',
            itemId: 'cancelPersonWindowButton',
            listeners: {
                click: function () {
                    this.up('window').close();
                }
            }
        }
    ],
    loadData: function (data) {
        console.log(data);
    }
});
