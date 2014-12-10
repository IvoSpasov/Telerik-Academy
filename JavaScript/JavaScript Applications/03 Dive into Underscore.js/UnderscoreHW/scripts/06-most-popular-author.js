(function () {
    'use strict';
    var Book = function () {
        function Book(name, author) {
            this.name = name;
            this.author = author;
        }

        return Book;
    }();

    var books = [
        new Book('Great Expectations', 'Charles Dickens'),
        new Book('The Sun Also Rises', 'Ernest Hemingway'),
        new Book('The Shining', 'Stephen King'),
        new Book('The Da Vinci Code', 'Dan Brown'),
        new Book('The Lord of the Rings', 'J.R.R Tolkien'),
        new Book('A Tale of Two Cities', 'Charles Dickens'),
        new Book('And Then There Were None', 'Agatha Christie'),
        new Book('Oliver Twist', 'Charles Dickens'),
        new Book('David Copperfield', 'Charles Dickens'),
        new Book('The Old Man and the Sea', 'Ernest Hemingway'),
        new Book('Murder on the Orient Express', 'Agatha Christie')
    ];

    var groupedByAuthor = _.groupBy(books, function (currentBook) {
        return currentBook.author;
    });

    var sortedByNumberOfBooks = _.sortBy(groupedByAuthor, function (currentSetOfBooks) {
        return currentSetOfBooks.length;
    });

    var mostPopularSetOfBooks = _.last(sortedByNumberOfBooks);
    var mostPopularAuthor = mostPopularSetOfBooks[0].author;
    console.log('The most popular author is: ' + mostPopularAuthor);


}());