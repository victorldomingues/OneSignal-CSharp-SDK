using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    /// <summary>
    /// API Documentation: https://documentation.onesignal.com/docs/notifications-create-notification
    /// </summary>
    public class NotificationCreateOptions
    {
        /// <summary>
        /// Your OneSignal application ID, which can be found on our dashboard at onesignal.com under App Settings > Keys & IDs. 
        /// It is a UUID and looks similar to 8250eaf6-1a58-489e-b136-7c74a864b434.
        /// </summary>
        [JsonProperty("app_id")]
        public Guid AppId { get; set; }

        /// <summary>
        /// The notification's content (excluding the title), a map of language codes to text for each language.
        /// Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language.
        /// English must be included in the hash.
        /// Example: {"en": "English Message", "es": "Spanish Message"}
        /// See the language codes you can use here: https://documentation.onesignal.com/docs/frequently-asked-questions#section-what-languages-codes-can-i-use-
        /// </summary>
        [JsonProperty("contents")]
        public IDictionary<string, string> Contents { get; set; }

        /// <summary>
        /// The notification's title, a map of language codes to text for each language.
        /// Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language.
        /// A default title may be displayed if a title is not provided. 
        /// Example: {"en": "English Title", "es": "Spanish Title"}
        /// See the language codes you can use here: https://documentation.onesignal.com/docs/frequently-asked-questions#section-what-languages-codes-can-i-use-
        /// </summary>
        [JsonProperty("headings")]
        public IDictionary<string, string> Headings { get; set; }

        /// <summary>
        /// A custom map of data that is passed back to your app.
        /// Example: {"abc": "123", "foo": "bar"}
        /// See the language codes you can use here: https://documentation.onesignal.com/docs/frequently-asked-questions#section-what-languages-codes-can-i-use-
        /// </summary>
        [JsonProperty("data")]
        public IDictionary<string, string> Data { get; set; }

        /// <summary>
        /// Targets notification recipients with filters. 
        /// This is a array of JSON objects containing field conditions to check.
        /// </summary>
        [JsonProperty("filters")]
		public IList<INotificationFilter> Filters { get; set; }

        /// <summary>
        /// Send based on OneSignal PlayerIds  
        /// </summary>
        [JsonProperty("include_player_ids")]
		public IList<string> IncludePlayerIds { get; set; }

        /// <summary>
        /// The segment names you want to target. 
        /// Users in these segments will receive a notification. 
        /// This targeting parameter is only compatible with excluded_segments.
        /// </summary>
        [JsonProperty("included_segments")]
        public IList<string> IncludedSegments { get; set; }

        /// <summary>
        /// Sets the web push notification's icon. 
        /// An image URL linking to a valid image. 
        /// Common image types are supported; GIF will not animate. 
        /// We recommend 256x256 (at least 80x80) to display well on high DPI devices. 
        /// Firefox will also use this icon, unless you specify firefox_icon.
        /// </summary>
        [JsonProperty("chrome_web_icon")]
        public string ChromeWebIcon { get; set; }

        /// <summary>
        /// The notification's subtitle, a map of language codes to text for each language.
        /// Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language. 
        /// A default title may be displayed if a title is not provided.
        /// This field supports <a href="https://documentation.onesignal.com/docs/notification-content#section-notification-content-substitution">inline substitutions</a>.
        /// Example: {"en": "English Subtitle", "es": "Spanish Subtitle"}
        /// Platforms: iOS 10+
        /// </summary>
        [JsonProperty("subtitle")]
        public IDictionary<string, string> Subtitle { get; set; }

        /// <summary>
        /// Use a template you setup on our dashboard. You can override the template values by sending other parameters with the request.
        /// The template_id is the UUID found in the URL when viewing a template on our dashboard.
        /// Platforms: ALL
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// Sending true wakes your app to run custom native code (Apple interprets this as content-available=1).
        /// Omit contents field to make notification silent.
        /// Platforms: iOS
        /// </summary>
        [JsonProperty("content_available")]
        public bool? ContentAvailable { get; set; }


        /// <summary>
        /// Sending true allows you to change the notification content in your app before it is displayed. 
        /// Triggers didReceive(_:withContentHandler:) on your UNNotificationServiceExtension.
        /// Platforms: iOS 10+
        /// </summary>
        [JsonProperty("mutable_content")]
        public bool? MutableContent { get; set; }

        /// <summary>
        /// The URL to open in the browser when a user clicks on the notification.
        /// Example: http://www.google.com
        /// This field supports <a href="https://documentation.onesignal.com/docs/notification-content#section-notification-content-substitution">inline substitutions</a>.
        /// Platforms: ALL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Adds media attachments to notifications. Set as JSON object, key as a media id of your choice and the value as a valid local file name or URL.
        /// User must press and hold on the notification to view.
        /// Do not set mutable_content to download attachments. The OneSignal SDK does this automatically.
        /// Example: {"id1": "https://domain.com/image.jpg"}
        /// Platforms: iOS 10+
        /// </summary>
        [JsonProperty("ios_attachments")]
        public IDictionary<string, string> IosAttachments { get; set; }

        /// <summary>
        /// Picture to display in the expanded view. Can be a drawable resource name or a URL.
        /// Platforms: Android
        /// </summary>
        [JsonProperty("big_picture")]
        public string BigPictureForAndroid { get; set; }

        /// <summary>
        /// Picture to display in the expanded view. Can be a drawable resource name or a URL.
        /// Platforms: Amazon
        /// </summary>
        [JsonProperty("adm_big_picture")]
        public string BigPictureForAmazon { get; set; }

        /// <summary>
        /// Picture to display in the expanded view. Can be a drawable resource name or a URL.
        /// Platforms: Chrome
        /// </summary>
        [JsonProperty("chrome_big_picture")]
        public string BigPictureForChrome { get; set; }

        /// <summary>
        /// Buttons to add to the notification. Icon only works for Android.
        /// Example: [{"id": "id1", "text": "button1", "icon": "ic_menu_share"}, {"id": "id2", "text": "button2", "icon": "ic_menu_send"}]
        /// Platforms: iOS 8.0+, Android 4.1+ (and derivatives like Amazon)
        /// </summary>
        [JsonProperty("buttons")]
        public IList<ActionButtonField> ActionButtons { get; set; }


        /// <summary>
        /// Add action buttons to the notification. The id field is required.
        /// Example: [{"id": "like-button", "text": "Like", "icon": "http://i.imgur.com/N8SN8ZS.png", "url": "https://yoursite.com"}, {"id": "read-more-button", "text": "Read more", "icon": "http://i.imgur.com/MIxJp1L.png", "url": "https://yoursite.com"}]
        /// Platforms: Chrome 48+
        /// </summary>
        [JsonProperty("web_buttons")]
        public IList<WebButtonField> WebButtons { get; set; }

        /// <summary>
        /// Category APS payload, use with registerUserNotificationSettings:categories in your Objective-C / Swift code.
        /// Example: calendar category which contains actions like accept and decline
        /// iOS 10+ This will trigger your UNNotificationContentExtension whose ID matches this category.
        /// Platforms: iOS
        /// </summary>
        [JsonProperty("ios_category")]
        public string IosCategory { get; set; }

        /// <summary>
        /// Allowing setting a background image for the notification. This is a JSON object containing the following keys. 
        /// See our <a href="https://documentation.onesignal.com/docs/android-customizations#section-background-images">Background Image documentation</a> for image sizes.
        /// image - Asset file, android resource name, or URL to remote image.
        /// headings_color - Title text color ARGB Hex format. Example(Blue): "FF0000FF".
        /// contents_color - Body text color ARGB Hex format. Example(Red): "FFFF0000"
        /// Example: {"image": "https://domain.com/background_image.jpg", "headings_color": "FFFF0000", "contents_color": "FF00FF00"}
        /// Platforms: Android
        /// </summary>
        [JsonProperty("android_background_layout")]
        public IList<AndroidBackgroundLayoutField> AndroidBackgroundLayout { get; set; }

        /// <summary>
        /// If blank the app icon is used. Must be the drawable resource name.
        /// See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-small-notification-icons">How to create small icons</a>
        /// Platforms: Android
        /// </summary>
        [JsonProperty("small_icon")]
        public string SmallAndroidIcon { get; set; }

        /// <summary>
        /// If blank the small_icon is used. Can be a drawable resource name or a URL.
        /// See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-large-notification-icons">How to create large icons</a>
        /// Platforms: Android
        /// </summary>
        [JsonProperty("large_icon")]
        public string LargeAndroidIcon { get; set; }

        /// <summary>
        /// Specific Amazon icon to use. 
        /// If blank the app icon is used. 
        /// Must be the drawable resource name.
        /// Platforms: Amazon
        /// </summary>
        [JsonProperty("adm_small_icon")]
        public string SmallAmazonIcon { get; set; }

        /// <summary>
        /// Specific Amazon icon to display to the left of the notification. 
        /// If blank the adm_small_icon is used. 
        /// Can be a drawable resource name or a URL.
        /// Platforms: Amazon
        /// </summary>
        [JsonProperty("adm_large_icon")]
        public string LargeAmazonIcon { get; set; }

        /// <summary>
        /// This flag is not used for web push For web push, please see chrome_web_icon instead.
        /// The local URL to an icon to use. If blank, the app icon will be used.
        /// Platforms: ChromeApp
        /// </summary>
        [JsonProperty("chrome_icon")]
        public string ChromeIcon { get; set; }

        /// <summary>
        /// Sound file that is included in your app to play instead of the default device notification sound. 
        /// Pass "nil" to disable vibration and sound for the notification.
        /// Platforms: iOS
        /// </summary>
        [JsonProperty("ios_sound")]
        public string IosSound { get; set; }


        /// <summary>
        /// Sound file that is included in your app to play instead of the default device notification sound. 
        /// NOTE: Leave off file extension for Android.
        /// Example: "notification"
        /// Platforms: Android
        /// </summary>
        [JsonProperty("android_sound")]
        public string AndroidSound { get; set; }

        /// <summary>
        /// Sound file that is included in your app to play instead of the default device notification sound.
        /// NOTE: Leave off file extension for Android.
        /// Example: "notification"
        /// Platforms: Amazon
        /// </summary>
        [JsonProperty("adm_sound")]
        public string AmazonSound { get; set; }

        /// <summary>
        /// Sound file that is included in your app to play instead of the default device notification sound.
        /// Example: "notification.wav"
        /// Platforms: Windows 8.0
        /// </summary>
        [JsonProperty("wp_sound")]
        public string WindowsPhoneSound { get; set; }

        /// <summary>
        /// Sound file that is included in your app to play instead of the default device notification sound.
        /// Example: "notification.wav"
        /// Platforms: Windows 8.1+
        /// </summary>
        [JsonProperty("wp_wns_sound")]
        public string WindowsRtPhoneSound { get; set; }

        /// <summary>
        /// Sets the devices LED notification light if the device has one. ARGB Hex format.
        /// Example(Blue): "FF0000FF"
        /// Platforms: Android
        /// </summary>
        [JsonProperty("android_led_color")]
        public string AndroidLedColor { get; set; }

        /// <summary>
        /// Sets the background color of the notification circle to the left of the notification text. 
        /// Only applies to apps targeting Android API level 21+ on Android 5.0+ devices.
        /// Example(Red): "FFFF0000"
        /// Platforms: Android
        /// </summary>
        [JsonProperty("android_accent_color")]
        public string AndroidAccentColor { get; set; }

        /// <summary>
        /// Sets the lock screen visibility for apps targeting Android API level 21+ running on Android 5.0+ devices.
        /// 1 = Public (default) (Shows the full message on the lock screen unless the user has disabled all notifications from showing on the lock screen. Please consider the user and mark private if the contents are.)
        /// 0 = Private (Hides message contents on lock screen if the user set "Hide sensitive notification content" in the system settings)
        /// -1 = Secret (Notification does not show on the lock screen at all)
        /// Platforms: Android 5.0+
        /// </summary>
        [JsonProperty("android_visibility")]
        public AndroidVisibilityEnum? AndroidVisibility { get; set; }

        /// <summary>
        /// Describes whether to set or increase/decrease your app's iOS badge count by the ios_badgeCount specified count. Can specify None, SetTo, or Increase.
        /// None - leaves the count unaffected.
        /// SetTo - directly sets the badge count to the number specified in ios_badgeCount.
        /// Increase - adds the number specified in ios_badgeCount to the total. Use a negative number to decrease the badge count.
        /// Platforms: iOS
        /// </summary>
        [JsonProperty("ios_badgeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IosBadgeTypeEnum? IosBadgeType { get; set; }

        /// <summary>
        /// Used with ios_badgeType, describes the value to set or amount to increase/decrease your app's iOS badge count by.
        /// You can use a negative number to decrease the badge count when used with an ios_badgeType of Increase.
        /// Platforms: iOS
        /// </summary>
        [JsonProperty("ios_badgeCount")]
        public int? IosBadgeCount { get; set; }

        /// <summary>
        /// Only one notification with the same id will be shown on the device. Use the same id to update an existing notification instead of showing a new one.
        /// his is known as apns-collapse-id on iOS and collapse_key on Android.
        /// Platforms: iOS 10+, Android
        /// </summary>
        [JsonProperty("collapse_id")]
        public string CollapseId { get; set; }

        /// <summary>
        /// Schedule notification for future delivery.
        /// Eventhough API suggests diffent datetime formats, we are using following format: "2015-09-24 14:00:00 GMT-0700"
        /// Platforms: ALL
        /// </summary>
        [JsonProperty("send_after")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime? SendAfter { get; set; }

        /// <summary>
        /// Possible values are:
        /// timezone (Deliver at a specific time-of-day in each users own timezone)
        /// last-active (Deliver at the same time of day as each user last used your app).
        /// If send_after is used, this takes effect after the send_after time has elapsed.
        /// Platforms: ALL
        /// </summary>
        [JsonProperty("delayed_option")]
        [JsonConverter(typeof(DelayedOptionJsonConverter))]
        public DelayedOptionEnum? DelayedOption { get; set; }

        /// <summary>
        /// Use with delayed_option=timezone.
        /// Example: "9:00AM"
        /// Platforms: ALL
        /// </summary>
        [JsonProperty("delivery_time_of_day")]
        public string DeliveryTimeOfDay { get; set; }


        /// <summary>
        /// Time To Live - In seconds. 
        /// The notification will be expired if the device does not come back online within this time.
        /// The default is 259,200 seconds (3 days).
        /// Platforms: iOS, Android, Chrome, ChromeWeb
        /// </summary>
        [JsonProperty("ttl")]
        public int? TimeToLive { get; set; }

        /// <summary>
        /// Delivery priority through the push server (example GCM/FCM). Pass 10 for high priority.
        /// Defaults to normal priority for Android and high for iOS.
        /// For Android 6.0+ devices setting priority to high will wake the device out of doze mode.
        /// Platforms: iOS, Android, Chrome, ChromeWeb
        /// </summary>
        [JsonProperty("priority")]
        public int? Priority { get; set; }


        /// <summary>
        /// All notifications with the same group will be stacked together using Android's <a href="https://developer.android.com/training/wearables/notifications/stacks.html">Notification Stacking</a> feature.
        /// Platforms: Android
        /// </summary>
        [JsonProperty("android_group")]
        public string AndroidGroup { get; set; }

        /// <summary>
        /// Summary message to display when 2+ notifications are stacked together. Default is "# new messages".
        /// Include $[notif_count] in your message and it will be replaced with the current number.
        /// Languages - The value of each key is the message that will be sent to users for that language. "en" (English) is required.
        /// The key of each hash is either a a 2 character language code or one of zh-Hans/zh-Hant for Simplified or Traditional Chinese.
        ///  Read more: <a href="https://documentation.onesignal.com/docs/language-localization#section-supported-languages">supported languages</a>.
        /// Example: {"en": "You have $[notif_count] new messages"}
        /// Platforms: Android
        /// </summary>
        [JsonProperty("android_group_message")]
        public string AndroidGroupMessage { get; set; }

        /// <summary>
        /// All notifications with the same group will be stacked together using Android's <a href="https://developer.android.com/training/wearables/notifications/stacks.html">Notification Stacking</a> feature.
        /// Platforms: Amazon
        /// </summary>
        [JsonProperty("adm_group")]
        public string AmazonGroup { get; set; }

        /// <summary>
        /// Summary message to display when 2+ notifications are stacked together.
        /// Default is "# new messages". Include $[notif_count] in your message and it will be replaced with the current number. 
        /// "en" (English) is required. 
        /// The key of each hash is either a a 2 character language code or one of zh-Hans/zh-Hant for Simplified or Traditional Chinese. 
        /// The value of each key is the message that will be sent to users for that language.
        /// Example: {"en": "You have $[notif_count] new messages"}
        /// Platforms: Amazon
        /// </summary>
        [JsonProperty("adm_group_message")]
        public string AmazonGroupMessage { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Apple iOS platform.
        /// Platforms: iOS
        /// </summary>
        [JsonProperty("isIos")]
        public bool? DeliverToIos { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Google Android platform.
        /// Platforms: Android
        /// </summary>
        [JsonProperty("isAndroid")]
        public bool? DeliverToAndroid { get; set; }

        /// <summary>
        /// Indicates whether to send to all subscribed web browser users, including Chrome, Firefox, and Safari.
        /// You may use this instead as a combined flag instead of separately enabling isChromeWeb, isFirefox, and isSafari, though the three options are equivalent to this one.
        /// Platforms: WEB
        /// </summary>
        [JsonProperty("isAnyWeb")]
        public bool? DeliverToAnyWeb { get; set; }


        /// <summary>
        /// Indicates whether to send to all Google Chrome, Chrome on Android, and Mozilla Firefox users registered under your Chrome &amp; Firefox web push platform.
        /// Platforms: WEB
        /// </summary>
        [JsonProperty("isChromeWeb")]
        public bool? DeliverToChromeWeb { get; set; }


        /// <summary>
        /// Indicates whether to send to all Mozilla Firefox desktop users registered under your Firefox web push platform.
        /// Platforms: WEB
        /// </summary>
        [JsonProperty("isFirefox")]
        public bool? DeliverToFirefox { get; set; }


        /// <summary>
        /// Does not support iOS Safari Indicates whether to send to all Apple's Safari desktop users registered under your Safari web push platform.
        /// Read more: <a href="https://documentation.onesignal.com/docs/why-doesnt-web-push-work-with-ios">iOS Safari</a>
        /// Platforms: WEB
        /// </summary>
        [JsonProperty("isSafari")]
        public bool? DeliverToSafari { get; set; }


        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Windows Phone 8.0 platform.
        /// Platforms: Windows Phone 8.0
        /// </summary>
        [JsonProperty("isWP")]
        public bool? DeliverToWindowsPhone { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Windows Phone 8.1+ platform.
        /// Platforms: Windows Phone 8.1+
        /// </summary>
        [JsonProperty("isWP_WNS")]
        public bool? DeliverToWindowsRtPhone { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Amazon Fire platform.
        /// Platforms: Amazon
        /// </summary>
        [JsonProperty("isAdm")]
        public bool? DeliverToAmazon { get; set; }

        /// <summary>
        /// This flag is not used for web push Please see isChromeWeb for sending to web push users. This flag only applies to Google Chrome Apps &amp; Extensions.
        /// Indicates whether to send to all devices registered under your app's Google Chrome Apps &amp; Extension platform.
        /// Platforms: ChromeApp
        /// </summary>
        [JsonProperty("isChrome")]
        public bool? DeliverToChrome { get; set; }

        public NotificationCreateOptions()
        {
            Contents = new Dictionary<string, string>();
            Headings = new Dictionary<string, string>();
        }
    }
}
