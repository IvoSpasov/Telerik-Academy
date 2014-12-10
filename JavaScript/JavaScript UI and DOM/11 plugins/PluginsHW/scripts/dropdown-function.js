(function ($) {
    $.fn.dropdown = function () {
        var $this = $(this),
            $div = $('<div>').addClass('dropdown-list-container').insertAfter($this),
            $ul = $('<ul>').addClass('dropdown-list-options').appendTo($div),
            $options = $this.children(),
            $currentOptionText,
            i;

        $this.css('display', 'none');
        for (i = 0; i < $options.length; i += 1) {
            $currentOptionText = $($options[i]).text();
            $('<li>').addClass('dropdown-list-option').attr('data-value', i).text($currentOptionText).appendTo($ul);
        }

        function onListOptionButtonClick() {
            $this = $(this);
            var value = parseInt($this.attr('data-value')) + 1,
                selector = 'option[value="' + value + '"]',
                currentOption = $('#dropdown').find(selector);

            if (currentOption.attr('selected') === 'selected') {
                currentOption.removeAttr('selected');
                $this.css('color', '');
            }
            else {
                currentOption.attr('selected', 'selected');
                $this.css('color', 'red');
            }

        }

        $('.dropdown-list-container').on('click', '.dropdown-list-option', onListOptionButtonClick);

        return $this;
    };
}(jQuery));