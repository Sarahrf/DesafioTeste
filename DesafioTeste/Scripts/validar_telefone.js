
if (typeof jQuery === 'undefined') {
    throw new Error('Bootstrap\'s JavaScript requires jQuery')
}

jQuery(document).ready(function ($) {
    /* =========== MASK FIELDS + VALIDATION ======== */
    /* == PHONE MASK == */

        var SPMaskBehavior = function validatel (val) {

            return val.replace(/\D/g, '').length === 11 ? '(00) 0 0000-0000' : '(00) 0000-00009';
    },

            spOptions = {
    onKeyPress: function(val, e, field, options) {
       field.mask(SPMaskBehavior.apply({}, arguments), options);
    }
};
$('.phone').mask(SPMaskBehavior, spOptions);