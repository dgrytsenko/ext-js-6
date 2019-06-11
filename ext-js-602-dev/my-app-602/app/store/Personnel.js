Ext.define('MyApp602.store.Personnel', {
    extend: 'Ext.data.Store',

    alias: 'store.personnel',

    useDefaultXhrHeader: false,

    storeId: 'store.personnel',

    fields: [
        'name', 'email', 'phone'
    ],

    proxy: {
        type: 'ajax',
        url: 'http://localhost:60362/api/personell/'
    },

    autoLoad: true
});
