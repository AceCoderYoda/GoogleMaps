var map = null;
var marker =null;
var trainee = { lat: 0, lng: 0, name: "", id: 0 };
var apiKey = "";


function init(key) {
    this.apiKey = key;
}

function initTrainee(lat, lng, name, id) {
    this.trainee.lat = lat;
    this.trainee.lng = lng;
    this.trainee.name = name;
    this.trainee.id = id;
}

function initMap() {
    var options = {
        zoom: 11,
        center: { lat: this.trainee.lat, lng: this.trainee.lng },
        disableDefaultUI: true,
        zoomControl: true,
        mapTypeControl: false,
        scaleControl: true,
        streetViewControl: false,
        rotateControl: false,
        fullscreenControl: false,
        gestureHandling: "cooperative"
    };

    this.map = new google.maps.Map(document.getElementById('map'), options);

    var newLatLng = new google.maps.LatLng(this.trainee.lat, this.trainee.lng);

    if (this.marker != undefined)
        this.marker.setPosition(newLatLng);
    else
        this.marker = new google.maps.Marker({
            position: newLatLng,
            label: this.trainee.name,
            map: this.map,
            draggable: true
        });

    var address = getAddress();
    var contentInfo = "<div class='container'>" +
        "<div class='row'>" +
        "<div class='col-md-12'><h4>Trainee Info</h4></div>" +
        "</div>" +
        "<div class='row'>" +
        "<div class='col-md-3'>Name</div>" +
        "<div class='col-md-1'>:</div>" +
        "<div class='col-md-8'>" +
        this.trainee.name +
        "</div>" +
        "</div>" +
        "<div class='row'>" +
        "<div class='col-md-3'>Id</div>" +
        "<div class='col-md-1'>:</div>" +
        "<div class='col-md-8'>" +
        this.trainee.id +
        "</div>" +
        "</div>" +
        "<div class='row'>" +
        "<div class='col-md-3'>Address</div>" +
        "<div class='col-md-1'>:</div>" +
        "<div class='col-md-8'>" +
        address +
        "</div>" +
        "</div>" +
        "<div class='row'>" +
        "<div class='col-md-3'>Lat. </div>" +
        "<div class='col-md-1'>:</div>" +
        "<div class='col-md-8'>" +
        this.trainee.lat +
        "</div>" +
        "</div>" +
        "<div class='row'>" +
        "<div class='col-md-3'>Lng. </div>" +
        "<div class='col-md-1'>:</div>" +
        "<div class='col-md-8'>" +
        this.trainee.lng +
        "</div>" +
        "</div>" +
        "</div>";


    var infowindow = new google.maps.InfoWindow({
        title: "Trainee Info",
        content: contentInfo
    });

    this.marker.addListener('click',
        function () {
            infowindow.open(map, marker);
        });
}

function getAddress() {
    var url =
        "https://maps.googleapis.com/maps/api/geocode/json?latlng=" +
        this.trainee.lat +
        "," +
        this.trainee.lng +
        "&key=" +
        this.apiKey;
    console.log(url);
    var address = "";
    $.when($.ajax({
        async: false,
        type: 'GET',
        url: url,
        success: function (data) {
            address = data.results[0].formatted_address;
        },
        error: function () {
            address = "";
        }
    }));

    return address;
}