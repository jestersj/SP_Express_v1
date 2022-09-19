function join(arr /*, separator */) {
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





function fillSelected3(suggestion) {
    let address = suggestion.data;

    if (address.postal_code) $("#PostalCode3").val(address.postal_code);
    else $("#PostalCode3").val(0);

    $("#Country3").val(address.country);

    $("#CountryISOCode3").val(address.country_iso_code);

    $("#Region3").val(address.region);

    $("#RegionISOCode3").val(address.region_iso_code);

    $("#RegionWithType3").val(join([
        join([address.region, address.region_type], ". "),
        join([address.area, address.area_type], " ")
    ]));

    $("#City3").val(join([
        join([address.city, address.city_type], ". "),
        join([address.settlement_type, address.settlement], " ")
    ]));

    $("#CityWithType3").val(address.city_with_type);

    $("#CapitalMarker3").val(address.capital_marker);

    $("#Street3").val(
        join([address.street, address.street_type], ". ")
    );

    $("#StreetWithType3").val(address.street_with_type);

    $("#Block3").val(address.block);

    $("#House3").val(join([
        join([address.house_type, address.house], ". "),
        join([address.block_type, address.block], " ")
    ]));

    if (address.qc_geo !== "5") {
        $("#Lat3").val(address.geo_lat);
        $("#Lon3").val(address.geo_lon);
        $("#Gc3").val(geoQuality(address.qc_geo));
    }
    else {
        $("#Lat3").val(0);
        $("#Lon3").val(0);
    }
    $("#Qc3").val(address.qc_geo);
    $("#Settlement3").val(address.settlement);
    $("#SettlementWithType3").val(address.settlement_with_type);
    $("#AddrCorrect3").val($("#AdrName3").val())
}


function fillSelected4(suggestion) {
    let address = suggestion.data;

    if (address.postal_code) $("#PostalCode4").val(address.postal_code);
    else $("#PostalCode4 ").val(0);

    $("#Country4").val(address.country);

    $("#CountryISOCode4").val(address.country_iso_code);

    $("#Region4").val(address.region);

    $("#RegionISOCode4").val(address.region_iso_code);

    $("#RegionWithType4").val(join([
        join([address.region, address.region_type], ". "),
        join([address.area, address.area_type], " ")
    ]));

    $("#City4").val(join([
        join([address.city, address.city_type], ". "),
        join([address.settlement_type, address.settlement], " ")
    ]));

    $("#CityWithType4").val(address.city_with_type);

    $("#CapitalMarker4").val(address.capital_marker);

    $("#Street4").val(
        join([address.street, address.street_type], ". ")
    );

    $("#StreetWithType4").val(address.street_with_type);

    $("#Block4").val(address.block);

    $("#House4").val(join([
        join([address.house_type, address.house], ". "),
        join([address.block_type, address.block], " ")
    ]));

    if (address.qc_geo !== "5") {
        $("#Lat4").val(address.geo_lat);
        $("#Lon4").val(address.geo_lon);
        $("#Gc4").val(geoQuality(address.qc_geo));
    }
    else {
        $("#Lat4").val(0);
        $("#Lon4").val(0);
    }
    $("#Qc4").val(address.qc_geo);
    $("#Settlement4").val(address.settlement);
    $("#SettlementWithType4").val(address.settlement_with_type);
    $("#AddrCorrect4").val($("#AdrName4").val())
}
function fillSelected5(suggestion) {
    let address = suggestion.data;

    if (address.postal_code) $("#PostalCode5").val(address.postal_code);
    else $("#PostalCode5 ").val(0);

    $("#Country5").val(address.country);

    $("#CountryISOCode5").val(address.country_iso_code);

    $("#Region5").val(address.region);

    $("#RegionISOCode5").val(address.region_iso_code);

    $("#RegionWithType5").val(join([
        join([address.region, address.region_type], ". "),
        join([address.area, address.area_type], " ")
    ]));

    $("#City5").val(join([
        join([address.city, address.city_type], ". "),
        join([address.settlement_type, address.settlement], " ")
    ]));

    $("#CityWithType5").val(address.city_with_type);

    $("#CapitalMarker5").val(address.capital_marker);

    $("#Street5").val(
        join([address.street, address.street_type], ". ")
    );

    $("#StreetWithType5").val(address.street_with_type);

    $("#Block5").val(address.block);

    $("#House5").val(join([
        join([address.house_type, address.house], ". "),
        join([address.block_type, address.block], " ")
    ]));

    if (address.qc_geo !== "5") {
        $("#Lat5").val(address.geo_lat);
        $("#Lon5").val(address.geo_lon);
        $("#Gc5").val(geoQuality(address.qc_geo));
    }
    else {
        $("#Lat5").val(0);
        $("#Lon5").val(0);
    }
    $("#Qc5").val(address.qc_geo);
    $("#Settlement5").val(address.settlement);
    $("#SettlementWithType5").val(address.settlement_with_type);
    $("#AddrCorrect5").val($("#AdrName5").val())
}


function corr() {
    $("#AdrName").val($("#AddrCorrect").val())
}
function corr2() {
    $("#AdrName2").val($("#AddrCorrect2").val())
}
function corr3() {
    $("#AdrName3").val($("#AddrCorrect3").val())
}
function corr4() {
    $("#AdrName4").val($("#AddrCorrect4").val())
}
function corr5() {
    $("#AdrName5").val($("#AddrCorrect5").val())
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
$("#AdrName3").suggestions({
    token: "5f97e9087c379f199f6fe7db05781c786b477562",
    type: "ADDRESS",
    onSelect: fillSelected3,
    onSelectNothing: corr3
});
$("#AdrName4").suggestions({
    token: "5f97e9087c379f199f6fe7db05781c786b477562",
    type: "ADDRESS",
    onSelect: fillSelected4,
    onSelectNothing: corr4
});
$("#AdrName5").suggestions({
    token: "5f97e9087c379f199f6fe7db05781c786b477562",
    type: "ADDRESS",
    onSelect: fillSelected5,
    onSelectNothing: corr5
});


function fillBankInfo(suggestion) {
    let info = suggestion.data;
    $('#bankName').val(suggestion.value)
    $('#AdrName5').val(info.address.value)
    $('#bik').
}

$("#bankInfo").suggestions({
    token: "5f97e9087c379f199f6fe7db05781c786b477562",
    type: "BANK",
    onSelect: fillBankInfo,
});