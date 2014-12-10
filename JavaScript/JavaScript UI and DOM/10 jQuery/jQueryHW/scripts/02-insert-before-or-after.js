(function () {
    // If the last parameter is true or missing, the item will be inserted after the specified index.
    // If it is false it will be inserted before the specified index.
    $.fn.insertBeforeOrAfter = function (atIndex, itemToInsert, isAfter) {
        if (isAfter === undefined) {
            isAfter = true;
        }

        var $this = $(this),
            elementAtIndex = $this.get(atIndex),  // DOM object
            $elementAtIndex = $(elementAtIndex);    // cast to jQuery object
        if (isAfter) {
            itemToInsert.insertAfter($elementAtIndex);
        }
        else {
            itemToInsert.insertBefore($elementAtIndex);
        }

        return $this;
    }

    var $wrapperChildren = $('#wrapper').children();
    //var $wrapperChildren = $('#wrapper').find('div');
    var $ul = $('<ul>');
    var $ul2 = $('<ul>');

    $wrapperChildren.insertBeforeOrAfter(0, $ul, true);
    //$wrapperChildren.insertBeforeOrAfter(0, $ul2, false);
}());