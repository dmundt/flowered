
/**
 * @fileoverview Provides the core JavaScript functionality
 * for the flowered toolbar.
 */

$(function(){	
  // hover and event logic for toolbar buttons
  $(".fg-button:not(.ui-state-disabled)")
  .hover(function() { 
    $(this).addClass("ui-state-hover"); 
  }, function() { 
    $(this).removeClass("ui-state-hover"); 
  })
  .mousedown(function() {
    $(this).parents('.fg-buttonset-single:first').find(".fg-button.ui-state-active").removeClass("ui-state-active");
    if ($(this).is('.ui-state-active.fg-button-toggleable, .fg-buttonset-multi .ui-state-active')) {
     $(this).removeClass("ui-state-active");
    } else {
     $(this).addClass("ui-state-active");
    }
  })
  .mouseup(function() {
    if (!$(this).is('.fg-button-toggleable, .fg-buttonset-single .fg-button, .fg-buttonset-multi .fg-button')) {
      $(this).removeClass("ui-state-active");
    }
  })
  .click(function() {
	FLOWERED_VARS['current_flower'] = this.id;
  });

  // hover logic for toolbar
  $(".fg-toolbar-flowered")
  .hover(function() { 
    $(this).addClass("ui-state-opacity-100"); 
  }, function() { 
    $(this).removeClass("ui-state-opacity-100"); 
  })
});
	