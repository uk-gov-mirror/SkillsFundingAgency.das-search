﻿var SearchAndShortlist = SearchAndShortlist || {};
(function (standard) {

    standard.CookieName = 'standards_shortlist';

    standard.Add = function(id) {
        var value = Cookies.get(standard.CookieName);
        if (!value || value.length === 0) {
            Cookies.set(standard.CookieName, '' + id, { expires: 365, HttpOnly: true, path: '/' });
        } else {
            var array = value.split(',');
            var index = array.indexOf(id);
            if (index < 0) {
                array.push(id);
            }
            Cookies.set(standard.CookieName, array.join(','), { expires: 365, HttpOnly: true, path: '/' });
        }
    };

    standard.Remove = function (id) {
        var value = Cookies.get(standard.CookieName);
        var array = value.split(',');
        var index = array.indexOf(id);
        if (index >= 0) {
            array.splice(index, 1);
        }
        Cookies.set(standard.CookieName, array.join(','), { expires: 365, HttpOnly: true, path: '/' });
    }


    standard.init = function () {
        $('.shortlist-link').on('click', function (e) {
            $this = $(this);
            var value = Cookies.get(standard.CookieName);
            if ($this.attr('data-action') === 'add') {
                standard.Add($(this).attr('data-standard'));
                $('.shortlist-link').attr('data-action', 'remove');
                $('.shortlist-link').html('Remove from shortlist');
            } else if ($this.attr('data-action') === 'remove') {
                standard.Remove($(this).attr('data-standard'));
                $('.shortlist-link').attr('data-action', 'add');
                $('.shortlist-link').html('Shortlist apprenticeship');
            };
            e.preventDefault();
        });
    };

    standard.init();

}(SearchAndShortlist.standard = {}));