function createCalendar(selector, events) {
    var YEAR = '2014';
    var MONTH = 'June';
    var MAX_MONTH_DAYS = 30;
    var WEEKS = 5;
    var WEEK_DAYS = ['Sat', 'Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri'];

    var preparedEvents = prepareEvents(events);

    var day = document.createElement('div');
    var dayTitle = document.createElement('h4');
    var dayEvent = document.createElement('span');
    var dayContent = document.createElement('div');
    var week = document.createElement('div');

    applyDayAttributes(day);
    applyDayTitleAttributes(dayTitle);
    applyDayEventAttributes(dayEvent);

    var calendar = document.querySelector(selector);
    var month = generateMonth();
    calendar.appendChild(month);

    function prepareEvents(events) {
        var result = [];
        for (var i = 0; i < events.length; i += 1) {
            var currentDate = events[i].date;
            result[currentDate] = events[i];
        }

        console.log(result);
        return result;
    }

    function generateMonth() {
        var frag = document.createDocumentFragment();
        var currentWeek;
        for (var i = 0; i < WEEKS; i += 1) {
            var startDay = (i * 7) + 1;
            var endDay = startDay + 6;
            currentWeek = generateWeek(startDay, endDay);
            frag.appendChild(currentWeek);
        }

        return frag;
    }

    function generateWeek(startDay, endDay) {
        var currentWeek = week.cloneNode(true);
        var currentDay;
        for (var i = startDay; i <= endDay && i <= MAX_MONTH_DAYS; i += 1) {
            currentDay = generateDay(i);
            currentWeek.appendChild(currentDay);
        }

        return currentWeek;
    }

    function generateDay(date) {
        var currentDay = day.cloneNode(true);
        var currentDayTitle = generateDayTitle(date);
        currentDay.appendChild(currentDayTitle);
        getCurrentEvent(date, currentDay);
        return currentDay;
    }

    function generateDayTitle(date) {
        var currentDayTitle = dayTitle.cloneNode(true);
        var currentDayAsString = WEEK_DAYS[date % 7];
        currentDayTitle.innerText = currentDayAsString + ' ' + date + ' ' + MONTH + ' ' + YEAR;
        return currentDayTitle;
    }

    function getCurrentEvent(date, dayElement) {
        var currentDateEvent = preparedEvents[date];
        if (currentDateEvent) {
            var currentDayEvent = dayEvent.cloneNode(true);
            currentDayEvent.innerText = currentDateEvent.hour + ' - ' + currentDateEvent.duration + ' minutes - ' + currentDateEvent.title;
            dayElement.appendChild(currentDayEvent);
        }
    }

    function applyDayAttributes(day) {
        day.classList.add('calendar-clickable-entry');

        day.style.display = 'inline-block';
        day.style.width = '130px';
        day.style.height = '130px';
        day.style.border = '1px solid black';
    }

    function applyDayTitleAttributes(dayTitle) {
        dayTitle.classList.add('calendar-clickable-entry');

        dayTitle.style.backgroundColor = 'lightgray';
        dayTitle.style.textAlign = 'center';
        dayTitle.style.borderBottom = '1px solid black';
        dayTitle.style.margin = '0';
    }

    function applyDayEventAttributes(dayEvent) {
        dayEvent.style.float = 'left';
    }

    calendar.addEventListener('click', function (ev) {
        if (ev.target.classList.contains('calendar-clickable-entry')) {

        }
    }, false);
}