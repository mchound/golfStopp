// Document ready

$(function () {

    GetClubs();
    var golfClubs;
    var map;

    function ExtendedClub(data) {

        this.MapLat = ko.observable(data.MapLat);
        this.MapLng = ko.observable(data.MapLat);
        this.Name = ko.observable(data.Name);
    }

    function ExtendedClubViewmodel() {

        var self = this;
        self.Name = ko.observable("");


    }
});

// Functions

function searchChanged() {
    var searchTerm = $('#searchInput').val();

   if (searchTerm.length == 0) {
        $('#clubTableBody').empty();
        return;
    }

    var arr = $.grep(golfClubs, function (club, index) {
        if (club.Name.toLowerCase().indexOf(searchTerm.toLowerCase()) >= 0) {
            return true;
        }

        return false;
    }).slice(0, 5);

    $('#clubTableBody').empty();

    $.each(arr, function (index, club) {

        $('#clubTableBody').append("<tr onclick=ClubDetails('" + club.Id + "')><td class='club_td'>" + club.Name + "</td><tr>");

    });

}

function ClubDetails(clubId) {

    $("#clubDetails_Tabs").tabs();
    $('#searchInput').val('');
    $('#clubTableBody').empty();

    $('#clubDetails_Container').slideDown(1000, function () {
        // Animation complete
    });
    InsertSpinnerBefore('#clubDetails_Content');
    $('#clubDetails_Spinner').show();
    $('#clubDetails_Content').hide();
    
    $.getJSON('http://localhost:52747/api/club/?clubIdExtended=' + clubId, function (data) {

        $('#clubDetails_Spinner').hide();
        $('#clubDetails_Content').show();
        PopulateClubContainer(data);

    }).error(function () {
        alert('Error when getting clubs');
    });
}

function GetClubs()
{
    $.getJSON('http://localhost:52747/api/club', function (data) {

        golfClubs = data;

    }).error(function () {
        alert('Error when getting clubs');
    });

}

function PopulateClubContainer(golfClubExtended) {

    InitializeMapForClub(golfClubExtended.MapLat, golfClubExtended.MapLng);

    $('#clubDetails_Tabs').bind('tabsshow', function (event, ui) {
        if (ui.panel.id == "tabs-1") {
            google.maps.event.trigger(map, 'resize')
            //resizeMap();
        }
    });

    $('#clubDetails_Header').children('div').children('span').text(golfClubExtended.Name);
    $('#clubDetilsHomepage').html("<a href='" + golfClubExtended.Homepage + "'>" + golfClubExtended.Homepage + "</a>");

    var courseSInfoTableRow;

    $.each(golfClubExtended.Courses, function (index, course) {
        $("#clubDetails_CourseList").append("<li onclick='ClubDetailsClicked()'>" + course.Name + "</li>");
        courseSInfoTableRow = "<tr><td>" + course.Name + "</td><td>" + course.NumberOfHoles + "</td><td>" + course.Par + "</td><td tile='Medelbetyg'>4.2</td><td tile='Svårighetsgrad'>3.6</td></tr>";
        $('#clubDetails_CoursesInfo').children('tbody').append(courseSInfoTableRow);
    });    

}

function InitializeMapForClub(mapLat, mapLng)
{
    var myOptions =
    {
        center: new google.maps.LatLng(mapLat, mapLng),
        zoom: 8, 
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    map = new google.maps.Map(document.getElementById("clubDetails_MapCanvas"), myOptions);   

    var image = '../../Images/golf_icon_37x37.png';
    var myLatLng = new google.maps.LatLng(mapLat, mapLng); 

    var beachMarker = new google.maps.Marker({
        position: myLatLng,
        map: map,
        icon: image 
    });

}

function ClubDetailsClicked() {

    $('#clubDetails_Container').slideUp(1000, function () {
        $('#courseDetails_Container').slideDown(1000, function () {
            AppendSpinnerTo('#courseDetails_Container');
            $('#clubDetails_Spinner').show();
        });
    });

}

function InsertSpinnerBefore(elementId) {

    var spinner = $('body').find('#clubDetails_Spinner');
    spinner.parent().remove('#clubDetails_Spinner');
    spinner.insertBefore($(elementId));
}

function InsertSpinnerAfter(elementId) {

    var spinner = $('body').find('#clubDetails_Spinner');
    spinner.parent().remove('#clubDetails_Spinner');
    spinner.insertAfter($(elementId));
}

function AppendSpinnerTo(element) {

    var spinner = $('body').find('#clubDetails_Spinner');
    spinner.parent().remove('#clubDetails_Spinner');
    $(element).append(spinner);
    spinner.hide();   
}

