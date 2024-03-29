﻿function join(arr /*, separator */) {
    var separator = arguments.length > 1 ? arguments[1] : ", ";
    return arr.filter(function (n) { return n }).join(separator);
}

function geoQuality(qc_geo) {
    var localization = {
        "0": "точные",
        "1": "ближайший дом",
        "2": "улица",
        "3": "населенный пункт",
        "4": "город"
    };
    return localization[qc_geo] || qc_geo;
}

function fillSelected(suggestion) {
    let address = suggestion.data;

    if (address.postal_code) $("#PostalCode").val(address.postal_code);
    else $("#PostalCode ").val(0);

    $("#Country").val(address.country);

    $("#CountryISOCode").val(address.country_iso_code);

    $("#Region").val(address.region);

    $("#RegionISOCode").val(address.region_iso_code);

    $("#RegionWithType").val(join([
        join([address.region, address.region_type], ". "),
        join([address.area, address.area_type], " ")
    ]));

    $("#City").val(join([
        join([address.city, address.city_type], ". "),
        join([address.settlement_type, address.settlement], " ")
    ]));

    $("#CityWithType").val(address.city_with_type);

    $("#CapitalMarker").val(address.capital_marker);

    $("#Street").val(
        join([address.street, address.street_type], ". ")
    );

    $("#StreetWithType").val(address.street_with_type);

    $("#Block").val(address.block);

    $("#House").val(join([
        join([address.house_type, address.house], ". "),
        join([address.block_type, address.block], " ")
    ]));

    if (address.qc_geo !== "5") {
        $("#Lat").val(address.geo_lat);
        $("#Lon").val(address.geo_lon);
        $("#Gc").val(geoQuality(address.qc_geo));
    }
    else {
        $("#Lat").val(0);
        $("#Lon").val(0);
    }
    $("#Qc").val(address.qc_geo);
    $("#Settlement").val(address.settlement);
    $("#SettlementWithType").val(address.settlement_with_type);
    $("#AddrCorrect").val($("#AdrName").val())
}


function fillSelected2(suggestion) {
    let address = suggestion.data;

    if (address.postal_code) $("#PostalCode2").val(address.postal_code);
    else $("#PostalCode2").val(0);

    $("#Country2").val(address.country);

    $("#CountryISOCode2").val(address.country_iso_code);

    $("#Region2").val(address.region);

    $("#RegionISOCode2").val(address.region_iso_code);

    $("#RegionWithType2").val(join([
        join([address.region, address.region_type], ". "),
        join([address.area, address.area_type], " ")
    ]));

    $("#City2").val(join([
        join([address.city, address.city_type], ". "),
        join([address.settlement_type, address.settlement], " ")
    ]));

    $("#CityWithType2").val(address.city_with_type);

    $("#CapitalMarker2").val(address.capital_marker);

    $("#Street2").val(
        join([address.street, address.street_type], ". ")
    );

    $("#StreetWithType2").val(address.street_with_type);

    $("#Block2").val(address.block);

    $("#House2").val(join([
        join([address.house_type, address.house], ". "),
        join([address.block_type, address.block], " ")
    ]));

    if (address.qc_geo !== "5") {
        $("#Lat2").val(address.geo_lat);
        $("#Lon2").val(address.geo_lon);
        $("#Gc2").val(geoQuality(address.qc_geo));
    }
    else {
        $("#Lat2").val(0);
        $("#Lon2").val(0);
    }
    $("#Qc2").val(address.qc_geo);
    $("#Settlement2").val(address.settlement);
    $("#SettlementWithType2").val(address.settlement_with_type);
    $("#AddrCorrect2").val($("#AdrName2").val())
}

function corr() {
    $("#AdrName").val($("#AddrCorrect").val())
}
function corr2() {
    $("#AdrName2").val($("#AddrCorrect2").val())
}


$("#AdrName").suggestions({
    token: "5f97e9087c379f199f6fe7db05781c786b477562",
    type: "ADDRESS",
    onSelect: fillSelected,
    onSelectNothing: corr
});

$("#AdrName2").suggestions({
    token: "5f97e9087c379f199f6fe7db05781c786b477562",
    type: "ADDRESS",
    onSelect: fillSelected2,
    onSelectNothing: corr2
});