$.fn.tabs = function () {
    var $tabsContainer = this;

    function showFirstTab() {
        var $firstTabItem = $tabsContainer.find('.tab-item:first-of-type');
        $firstTabItem.addClass('current');
        $firstTabItem.find('.tab-item-content').show();
    }

    function hideTabItemContent() {
        $tabsContainer.find('.tab-item-content').hide();
    }

    function onTabItemTitleButtonClick() {
        var $tabItemTitle = $(this);
        $tabsContainer.find('.tab-item').removeClass('current');
        $tabItemTitle.parent().addClass('current');
        hideTabItemContent();
        $tabItemTitle.parent().find('.tab-item-content').show();
    }

    $tabsContainer.addClass('tabs-container');
    hideTabItemContent();
    showFirstTab();
    $tabsContainer.on('click', '.tab-item-title', onTabItemTitleButtonClick);
};
