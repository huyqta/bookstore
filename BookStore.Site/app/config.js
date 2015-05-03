// NOT USE

var config_module = angular.module('myApp.config', []);

var config_data = {
    'APP_CONFIG': {
        'APP_NAME': 'Book Store',
        'APP_VERSION': '1.0',
        'HOST_API_ADDRESS': 'http://localhost/BookStore.WebAPI/',
        'API_ADDRESS': {
            'BOOK_API': 'api/books',
            'TAG_API': 'api/tags'
        },
        'CUSTOM_API_ADDRESS': {
            'GET_LATEST_BOOK': 'SelectLastestBook',
            'SEARCH_BY_TAG': 'SearchBookByTag',
            'SEARCH_BY_NAME': 'SearchBookByName'
        }
    }
};

angular.forEach(config_data,function(key,value) {
    config_module.constant(value,key);
});