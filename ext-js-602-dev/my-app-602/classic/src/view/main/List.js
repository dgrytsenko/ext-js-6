/**
 * This view is an example list of people.
 */
Ext.define('MyApp602.view.main.List', {
    extend: 'Ext.grid.Panel',
    xtype: 'mainlist',

    requires: [
        'MyApp602.store.Personnel'
    ],

    title: 'Personnel',

    align: 'left',

    store: {
        type: 'personnel'
    },

    columns: [
        { text: 'Name',  dataIndex: 'name', width: 200, align: 'left' },
        { text: 'Email', dataIndex: 'email', flex: 1, align: 'left' },
        { text: 'Phone', dataIndex: 'phone', flex: 1, align: 'left' }
    ],

    listeners: {
        select: 'onItemSelected'
    }
});
