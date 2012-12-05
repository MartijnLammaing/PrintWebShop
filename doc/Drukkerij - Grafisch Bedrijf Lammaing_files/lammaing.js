addEvent(window, 'load', initCorners);

  function initCorners() {



    var settings = {
      tl: { radius: 15 },
      tr: { radius: 15 },
      bl: { radius: 15 },
      br: { radius: 15 },
      antiAlias: true
    }

     var settings2= {
      tl: { radius: 15 },
      tr: { radius: 15 },
      bl: { radius: 15 },
      br: { radius: 15 },
      antiAlias: true
    }

    var settings3= {
      tl: { radius: 5 },
      tr: { radius: 5 },
      bl: { radius: 5 },
      br: { radius: 5 },
      antiAlias: true
    }
    
    var settings4= {
      tl: { radius: 3 },
      tr: { radius: 15 },
      bl: { radius: 15 },
      br: { radius: 3 },
      antiAlias: true
    }


    /*
    Usage:

    curvyCorners(settingsObj, selectorStr);
    curvyCorners(settingsObj, Obj1[, Obj2[, Obj3[, . . . [, ObjN]]]]);

    selectorStr ::= complexSelector [, complexSelector]...
    complexSelector ::= singleSelector[ singleSelector]
    singleSelector ::= idType | classType
    idType ::= #id
    classType ::= [tagName].className
    tagName ::= div|p|form|blockquote|frameset // others may work
    className : .name
    selector examples:
      #mydiv p.rounded
      #mypara
      .rounded
    */
    curvyCorners(settings, ".home-banner");
    curvyCorners(settings2, ".background");
    curvyCorners(settings2, ".movie");
    curvyCorners(settings4, ".gebouw");
    curvyCorners(settings3, ".youtube_red");
    curvyCorners(settings3, ".youtube_white");



  }

