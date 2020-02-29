using System.Collections.Generic;

namespace eaw.dtac.petroglyph.xml.gameconstants
{
    internal static class Tags
    {
        internal static List<string> GetAll()
        {
            return new List<string>
            {
                DEFAULT_DEFENSE_ADJUST,
                STARTING_GALACTIC_CAMERA_POSITION,
                CAMERA_STOP_LEFT,
                CAMERA_STOP_RIGHT,
                CAMERA_Z_POSITION,
                FLEET_MOVEMENT_LINE_TEXTURE_NAME,
                FLEET_HYPERSPACE_BAND_TEXTURE_NAME,
                LOOPWAYPOINTLINETEXTURENAME,
                WAYPOINTLINETEXTURENAME,
                WAYPOINTFLAGMODELNAME,
                FLEET_MAINTENANCE_UPDATE_DELAY_SECONDS,
                PAY_AS_YOU_GO,
                USE_NEUTRAL_UI_COLOR,
                NEUTRAL_UI_COLOR,
                PLAYER_COLOR,
                ENEMY_COLOR,
                SPACE_AUTO_RESOLVE_DELAY_SECONDS,
                LAND_AUTO_RESOLVE_DELAY_SECONDS,
                PRODUCTION_SPEED_FACTOR,
                POLITICAL_CONTROL_CHANGE_TIME_SECONDS,
                POLITICAL_INCOME_CURVE,
                PROGRESSIVE_TAXATION,
                INCOME_REDISTRIBUTION,
                CREDIT_CAP_PER_PLANET,
                FISCAL_CYCLE_TIME_IN_SECS,
                MEDIUM_COIN_STACK_SIZE,
                LARGE_COIN_STACK_SIZE,
                BLACK_MARKET_INCOME_MULT_MIN,
                BLACK_MARKET_INCOME_MULT_MAX,
                NUM_STRUCTURES_FOR_MEDIUM_PLANET_NAME,
                NUM_STRUCTURES_FOR_LARGE_PLANET_NAME,
                MAXIMUMPOLITICALCONTROL,
                MAXIMUMSTARBASELEVEL,
                MAXIMUMGROUNDBASELEVEL,
                MAXIMUMSPECIALSTRUCTURES,
                MAXIMUMSPECIALSTRUCTURESLAND,
                MAXIMUMSPECIALSTRUCTURESSPACE,
                MAXIMUMFLEETMOVEMENTDISTANCE,
                SHIPNAMETEXTFILES,
                TRADEROUTEMOVEMENTFACTOR,
                GMC_INITIALPITCHANGLEDEGREES,
                GMC_ZOOMEDPITCHANGLEDEGREES,
                GMC_INITIALPULLBACKDISTANCE,
                GMC_ZOOMEDPULLBACKPLANETRADIUSFRACTION,
                GMC_ZOOMEDPOSITIONOFFSETPLANETRADIUSFRACTIONS,
                GMC_ZOOMTIME,
                GMC_BATTLE_ZOOM_TIME,
                GMC_BATTLE_FADE_TIME,
                GALACTIC_RIGHT_BUTTON_SCROLL_SPEED_FACTOR,
                GALACTIC_SCROLL_PLANE,
                PUSH_SCROLL_SPEED_MODIFIER,
                SCROLL_DECELERATION_FACTOR,
                SCROLL_ACCELERATION_FACTOR,
                GUI_MOVE_COMMAND_ACK_EFFECT,
                GUI_DOUBLE_CLICK_MOVE_COMMAND_ACK_EFFECT,
                GUI_ATTACK_MOVE_COMMAND_ACK_EFFECT,
                GUI_GUARD_MOVE_COMMAND_ACK_EFFECT,
                GUI_ATTACK_MOVEMENT_CLICK_RADAR_EVENT_NAME,
                GUI_MOVEMENT_CLICK_RADAR_EVENT_NAME,
                GUI_MOVEMENT_DOUBLE_CLICK_RADAR_EVENT_NAME,
                GUI_MOVE_ACKNOWLEDGE_SCALE_LAND,
                GUI_MOVE_ACKNOWLEDGE_SCALE_SPACE,
                TOOLTIP_DELAY,
                TEXT_REVEAL_RATE,
                ENCYCLOPEDIA_DELAY,
                LONG_ENCYCLOPEDIA_DELAY,
                MAP_PREVIEW_IMAGE_SIZE,
                JAPANESE_ST_LINE_PERCENT,
                ELEVATED_VULNERABILITY_DURATION,
                ELEVATED_VULNERABILITY_FACTOR,
                SPACE_ELEVATED_VULNERABILITY_DURATION,
                SPACE_ELEVATED_VULNERABILITY_FACTOR,
                TELEKINESIS_HOVER_HEIGHT,
                TELEKINESIS_TRANSITION_TIME,
                TELEKINESIS_WOBBLE_CYCLE_TIME,
                TELEKINESIS_WOBBLE_FADE_TIME,
                TELEKINESIS_MAX_WOBBLE_ANGLE,
                TELEKINESIS_MAX_BOB_HEIGHT,
                EARTHQUAKE_TRANSITION_TIME,
                EARTHQUAKE_SHAKE_SPEED,
                EARTHQUAKE_SHAKE_MAGNITUDE,
                AIUSESFOGOFWARGALACTIC,
                AIUSESFOGOFWARSPACE,
                AIUSESFOGOFWARLAND,
                SETUPPHASEENABLED,
                ALWAYSBYPASSAUTORESOLVE,
                AUTOMATICAUTORESOLVE,
                AUTORESOLVEVOTEDEFAULTTOTACTICAL,
                AUTORESOLVEVOTEDEFAULTTIMEOUT,
                PLAYMODESWITCHMOVIES,
                SHIELDRECHARGEINTERVALINSECS,
                ENERGYRECHARGEINTERVALINSECS,
                ENERGYTOSHIELDEXCHANGERATE,
                MAXINFLUENCETRANSITIONALIGNMENTBONUS,
                MAXINFLUENCETRANSITIONALIGNMENTPENALTY,
                MAXCREDITINCOMEALIGNMENTBONUS,
                MAXCREDITINCOMEALIGNMENTPENALTY,
                MAXCOMBATACCURACYALIGNMENTBONUS,
                MAXCOMBATDAMAGEALIGNMENTBONUS,
                MAXCOMBATSENSORRANGEALIGNMENTBONUS,
                MAX_GALACTIC_ZOOM_DISTANCE,
                MIN_GALACTIC_ZOOM_SPEED,
                MAX_GALACTIC_ZOOM_SPEED,
                GALACTIC_ZOOM_ACCELERATION,
                GALACTIC_ZOOM_LIGHT_LEVEL,
                GALACTIC_ZOOM_IN_LIGHT_ANGLE,
                GALACTIC_ZOOM_OUT_LIGHT_ANGLE,
                GALACTIC_ZOOM_IN_STATION_OFFSET,
                GALACTIC_ZOOM_IN_STATION_ROTATION,
                RANDOM_STORY_TRIGGERS,
                RANDOM_STORY_MAX_TRIGGERS,
                RANDOM_STORY_REBEL_CONSTRUCTION,
                RANDOM_STORY_EMPIRE_CONSTRUCTION,
                RANDOM_STORY_REBEL_DESTROY,
                RANDOM_STORY_EMPIRE_DESTROY,
                RANDOM_STORY_REWARDS,
                RANDOM_STORY_REWARD_REBEL_BUILDABLE,
                RANDOM_STORY_REWARD_EMPIRE_BUILDABLE,
                RANDOM_STORY_REWARD_REBEL_UNIT,
                RANDOM_STORY_REWARD_EMPIRE_UNIT,
                MAX_GROUND_FORCES_ON_PLANET,
                ALLOW_REINFORCEMENT_PERCENTAGE_NORMALIZED,
                TACTICAL_EDGE_SCROLL_REGION,
                TACTICAL_MAX_SCROLL_SPEED,
                TACTICAL_MIN_SCROLL_SPEED,
                TACTICAL_OFFSCREEN_SCROLL_REGION,
                STRATEGIC_EDGE_SCROLL_REGION,
                STRATEGIC_MAX_SCROLL_SPEED,
                STRATEGIC_MIN_SCROLL_SPEED,
                STRATEGIC_OFFSCREEN_SCROLL_REGION,
                HARDPOINT_TARGET_RETICLE_ENEMY_SCREEN_SIZE,
                HARDPOINT_TARGET_RETICLE_FRIENDLY_SCREEN_SIZE,
                HARDPOINT_TARGET_RETICLE_ENEMY_TEXTURE,
                HARDPOINT_TARGET_RETICLE_ENEMY_TRACKED_TEXTURE,
                HARDPOINT_TARGET_RETICLE_FRIENDLY_TEXTURE,
                HARDPOINT_TARGET_RETICLE_FRIENDLY_TRACKED_TEXTURE,
                HARDPOINT_TARGET_RETICLE_FRIENDLY_REPAIRING_TEXTURE,
                HARDPOINT_TARGET_RETICLE_FRIENDLY_DISABLED_TEXTURE,
                HARDPOINT_TARGET_RETICLE_FRIENDLY_DISABLED_TRACKED_TEXTURE,
                DEBUG_HOT_KEY_LOAD_MAP,
                DEBUG_HOT_KEY_LOAD_MAP_SCRIPT,
                DEBUG_HOT_KEY_LOAD_CAMPAIGN,
                GAME_SCORING_SCRIPT_NAME,
                SHOWUNITAIPLANATTACHMENT,
                AI_SPACEEVALUATORREGIONSIZE,
                AI_LANDEVALUATORREGIONSIZE,
                AI_SPACETHREATDISTANCEFACTOR,
                AI_LANDTHREATDISTANCEFACTOR,
                AI_SPACETHREATTURNRATEFACTOR,
                AI_LANDTHREATTURNRATEFACTOR,
                AI_SPACETHREATLOOKAHEADTIME,
                AI_LANDTHREATLOOKAHEADTIME,
                AI_SPACEAREATHREATSCALEFACTOR,
                AI_LANDAREATHREATSCALEFACTOR,
                AI_FOGCELLSPERTHREATCELL,
                AI_SPACETHREATDECAYSTEP,
                AI_BUILDTASKRESERVATIONSECONDS,
                AI_LANDTHREATRANGECAP,
                AI_SPACETHREATRANGECAP,
                SPACEFOWCOLOR,
                LANDFOWCOLOR,
                SPACEREINFORCEFOWCOLOR,
                SETUPPHASEFOWCOLOR,
                SETUPPHASEINVALIDDRAGCOLOR,
                SETUPPHASECOUNTDOWNSECONDS,
                SPACEFOWHEIGHT,
                GOOD_GROUND_COLOR_TINT,
                RETREAT_COLOR_TINT,
                HIGH_GROUND_COLOR_TINT,
                SLOW_GROUND_COLOR_TINT,
                LAVA_GROUND_COLOR_TINT,
                INFANTRY_GROUND_COLOR_TINT,
                DESIREDLANDFOWCELLSIZE,
                DESIREDSPACEFOWCELLSIZE,
                LANDFOWREGROWTIME,
                SPACEFOWREGROWTIME,
                SPACEREINFORCEFEEDBACKONLYWHILEDRAGGING,
                WATER_RENDER_TARGET_RESOLUTION,
                WATER_CLIP_PLANE_OFFSET,
                OCCLUSION_SILHOUETTES_ENABLED,
                LASER_BEAM_Z_SCALE_FACTOR,
                LASER_KITE_Z_SCALE_FACTOR,
                MOUSE_OVER_HIGHLIGHT_SCALE,
                DEFAULT_HERO_RESPAWN_TIME,
                MINIMUMDRAGDISTANCE,
                MINIMUMDRAGSELECTDISTANCE,
                SPACEPATHFINDMAXEXPANSIONS,
                CURRENTPATHCOSTCOEFFICIENTSPACE,
                SPACEPATHFINDFRAMEDELAYDELTA,
                SPACEPATHFAILUREDISTANCECUTOFFCOEFFICIENT,
                SPACEPATHFAILUREMAXEXPANSIONSCOEFFICIENT,
                SPACEPATHFAILUREROTATIONEXPANSIONINCREMENT,
                SPACEPATHFAILUREFORWARDEXPANSIONINCREMENT,
                SPACEPATHINGTRIES,
                SPACESTATICOBSTACLEAVOIDANCEBONUSDISTANCE,
                MINOBSTACLECOSTSPACE,
                MAXOBSTACLECOSTSPACE,
                OBSTACLEAREAOVERLAPFORMAXSPACE,
                XYEXPANSIONDISTANCESPACE,
                MAXROTATIONSSPACE,
                MATCHFACINGDELTASPACE,
                OCCUPATIONRADIUSCOEFFICIENTSPACE,
                DESTINATIONSEARCHRADIUSINCREMENTSPACE,
                USELINEARCOLLISIONCHECKS,
                WAITOPERATORCOSTCOEFFICIENT,
                WAITOPERATORBASEFRAMETIME,
                WAITOPERATORSPEEDCOEFFICIENT,
                LANDWAITOPERATORSPEEDCOEFFICIENT,
                SPACELOCOMOTORFACINGLOOKAHEADACC,
                FINALFACING180PENALTY,
                SPECIALALIGNEDOPERATORBONUS,
                THREATEXPANSIONDISTANCE,
                OFFMAPCOSTPENALTY,
                MAXLANDFORMATIONFORMUPFRAMES,
                MOVEMENTREEVALUATIONFRAMECOUNT,
                ASTEROID_FIELD_DAMAGE,
                ASTEROID_FIELD_DAMAGE_RATE,
                GUI_FLASH_LEVEL,
                GUI_FLASH_DURATION,
                GUI_RAPID_FLASH_DURATION,
                GUI_CYCLE_SPEED,
                GUI_DARKEN_LEVEL,
                GUI_CYCLE_COLOR,
                GUI_HILITE_LEVEL,
                GUI_PLANET_FLASH_LEVEL,
                GUI_PLANET_FADE_DURATION,
                CB_FLASH_DURATION,
                CB_FLASH_COUNT,
                ICONS_PER_COLUMN,
                HINT_TEXT_COLOR,
                SYSTEM_TEXT_COLOR,
                TASK_TEXT_COLOR,
                SPEECH_TEXT_COLOR,
                DROID_TEXT_COLOR,
                DROID_DATE_COLOR,
                DROID_SEPERATOR_COLOR,
                CB_MOVIE_OFFSET,
                CB_MOVIE_COLOR,
                GOOD_SIDE_NAME,
                EVIL_SIDE_NAME,
                CORRUPT_SIDE_NAME,
                GOOD_SIDE_LEADER_NAME,
                EVIL_SIDE_LEADER_NAME,
                CORRUPT_SIDE_LEADER_NAME,
                ENCYCLOPEDIA_POPULATION_OFFSET,
                ENCYCLOPEDIA_NAME_OFFSET,
                ENCYCLOPEDIA_COST_OFFSET,
                ENCYCLOPEDIA_ICON_X_OFFSET,
                ENCYCLOPEDIA_ICON_Y_OFFSET,
                ENCYCLOPEDIA_CLASS_Y_OFFSET,
                ENCYCLOPEDIA_FADE_RATE,
                ENCYCLOPEDIA_MIN_DISPLAY_TIME,
                MIN_ACCURACY_FOR_ICON,
                MIN_SIGHT_RANGE_FOR_ICON,
                LEFT_QUEUE_TINT,
                RIGHT_QUEUE_TINT,
                GUI_TACTICAL_COUNTDOWN_TIMERS_SCREEN_X,
                GUI_TACTICAL_COUNTDOWN_TIMERS_SCREEN_Y,
                GUI_TACTICAL_COUNTDOWN_TIMERS_SCREEN_SPACING,
                GUI_STRATEGIC_COUNTDOWN_TIMERS_SCREEN_X,
                GUI_STRATEGIC_COUNTDOWN_TIMERS_SCREEN_Y,
                GUI_STRATEGIC_COUNTDOWN_TIMERS_SCREEN_SPACING,
                BEACONPLACEDELAY,
                WAYPOINTLINELANDDASHLENGTH,
                WAYPOINTLINELANDGAPLENGTH,
                WAYPOINTLINELANDDASHVELOCITY,
                MAXWAYPOINTSPERPATH,
                IDLEWALKBLENDTIME,
                CROUCHIDLEWALKBLENDTIME,
                MOVEBLENDTIME,
                CROUCHMOVEBLENDTIME,
                TEAMMOVEBLENDTIME,
                TEAMCROUCHMOVEBLENDTIME,
                INFANTRYTURNBLENDTIME,
                SPACEOBJECTTRACKINGINTERVAL,
                LANDOBJECTTRACKINGINTERVAL,
                SPACEOBJECTTRACKINGTREECOUNT,
                LANDOBJECTTRACKINGTREECOUNT,
                MINOBSTACLECOSTLAND,
                MAXOBSTACLECOSTLAND,
                XYEXPANSIONDISTANCELAND,
                SHOULDDISPLAYPREDICTIONPATHS,
                SHOULDDISPLAYSYNCEDPATHS,
                SYNCEDFRAMEINTERVAL,
                LANDPREDICTIONTIMEINTERVAL,
                REPUSHDISTANCE,
                MINLANDPREDICTIONDISTANCE,
                SHOULDSKIPLANDFORMUP,
                SHOULDINFANTRYTEAMSSPLITACROSSFORMATIONS,
                VEHICLEFORMATIONRECRUITMENTDISTANCE,
                INFANTRYFORMATIONRECRUITMENTDISTANCE,
                FRAMESPERCOLLISIONCHECK,
                CLOSEENOUGHANGLEFORMOVESTART,
                DYNAMICOBSTACLEOVERLAPPENALTY,
                DYNAMICAVOIDANCERECTANGLEBOUND,
                SHOULDDISPLAYPOTENTIALPATH,
                TURNINPLACESLOWDOWNCORVETTE,
                TURNINPLACESLOWDOWNFRIGATE,
                TURNINPLACESLOWDOWNCAPITAL,
                FORMATIONMINIMUMSIDEERROR,
                FORMATIONMAXIMUMSIDEERROR,
                APPROXIMATIONSMOOTHCOSANGLE,
                APPROXIMATIONFORWARDDISTANCE,
                MINIMUMSTOPPEDVSSTOPPEDOVERLAPCOEFFICIENT,
                MOVINGVSMOVINGLOOKAHEADTIME,
                LANDDESTINATIONPROXIMITY,
                LANDTEMPORARYDESTINATIONPROXIMITY,
                BETWEENFORMATIONSPACING,
                PREFERRED_PATHFINDER_TYPES,
                DESTINATION_COLLISION_QUERY_EXTENSION,
                FRAMESPERPOSITIONAPPROXIMATIONREBUILD,
                DYNAMICLANDCOMPLEXITYQUOTA,
                DYNAMICLANDQUOTARESETINTERVAL,
                FINALFORMATIONFACINGMINIMUMANGLE,
                FINALFORMATIONFACINGDELTACOEFFICIENT,
                WALKANIMATIONCUTOFF,
                DOUBLECLICKMOVEMAXSPEEDRATIO,
                FLEEING_INFANTRY_SPEED_BONUS,
                SHIELD_FLASH_SCALE,
                SHIELD_FLASH_DURATION,
                HULL_VS_HARD_POINTS_HEALTH_CONSTRAINT,
                LOW_THREAT_REACHABILITY_TOLERANCE,
                MEDIUM_THREAT_REACHABILITY_TOLERANCE,
                HIGH_THREAT_REACHABILITY_TOLERANCE,
                OVERRUN_AUTO_RESOLVE_MULTIPLE,
                AUTORESOLVEATTRITIONALLOWANCEFACTOR,
                AUTORESOLVETRANSPORTLOSSES,
                AUTORESOLVEDISPLAYTIME,
                RETREATAUTORESOLVELOSERATTRITION,
                RETREATAUTORESOLVEWINNERATTRITION,
                AUTORESOLVELOSERATTRITION,
                AUTORESOLVEWINNERATTRITION,
                MINIMUM_TACTICAL_OVERRUN_TIME_IN_SECS,
                TACTICAL_OVERRUN_MULTIPLE,
                OBJECT_MAX_SPEED_MULTIPLIER_GALACTIC,
                OBJECT_MAX_SPEED_MULTIPLIER_SPACE,
                OBJECT_MAX_SPEED_MULTIPLIER_LAND,
                OBJECT_MAX_HEALTH_MULTIPLIER_SPACE,
                OBJECT_MAX_HEALTH_MULTIPLIER_LAND,
                AUTO_ROTATE_FOR_SPACE_TARGETING,
                AUTO_ADJUST_MOVE_FOR_SPACE_TARGETING,
                IN_GAME_CINEMATICS,
                PRODUCTION_SPEED_MOD_BASE_VS_TECH_0,
                PRODUCTION_SPEED_MOD_BASE_VS_TECH_1,
                PRODUCTION_SPEED_MOD_BASE_VS_TECH_2,
                PRODUCTION_SPEED_MOD_BASE_VS_TECH_3,
                PRODUCTION_SPEED_MOD_BASE_VS_TECH_4,
                ENGINES_DISABLED_SPEED_MODIFIER,
                CROUCH_MOVE_FIRE_ANGLE_CUTOFF,
                MAX_MOVE_FRAME_DELAY,
                SPREAD_OUT_SPACING_COEFFICIENT,
                MAX_FORMATION_AREA,
                SHORT_RANGE_ATTACK_FORMATION_COEFFICIENT,
                SOLO_ATTACK_RANGE,
                BASE_LAND_TARGETING_ARC_ANGLE_COEFFICIENT,
                ROTATE_FORMATION_FACING_MOVES,
                SHOULDUSESPACEIDLEMOVEMENT,
                SPACEIDLEMOVEMENTSPEED,
                SPACEIDLEPATHCULLCOEFFICIENT,
                IDLEMOVEMENTFRAMES,
                GRIPPERCOMBATGRIDSNAPDISTANCE,
                DAMAGE_TYPES,
                ARMOR_TYPES,
                DAMAGE_TO_ARMOR_MOD,
                UNIT_COMMAND_RANKINGS_BY_CATEGORY,
                PLANET_ABILITY_ICON_NAMES,
                PLANET_ABILITY_TEXT_IDS,
                PLANET_ABILITY_RGBS,
                DROID_ENCYCLOPEDIA_OFFSET,
                REINFORCEMENTOVERLAYGOODCOLOR,
                REINFORCEMENTOVERLAYBADCOLOR,
                DISPLAY_BINK_MOVIE_FRAMES,
                MIN_SKIRMISH_CREDITS,
                MAX_SKIRMISH_CREDITS,
                TACTICAL_BUILD_TIME_MULTIPLIER,
                SPACE_RETREAT_ATTRITION_FACTOR,
                LAND_RETREAT_ATTRITION_FACTOR,
                BLOCKADE_RUN_ATTRITION_FACTOR,
                TRANSPORT_REFILL_THRESHOLD,
                SQUADRON_REFILL_THRESHOLD,
                SPACE_TACTICAL_CAMERA_LOCKED,
                LAND_TACTICAL_CAMERA_LOCKED,
                SPACE_COLLIDABLE_GRID_CULL_SIZE,
                LAND_COLLIDABLE_GRID_CULL_SIZE,
                SPACE_LARGE_SHIP_GRID_CULL_SIZE,
                RAID_FORCE_FREE_OBJECT_CATEGORY_MASK,
                RAID_FORCE_LIMITED_OBJECT_CATEGORY_MASK,
                RAID_FORCE_MAX_LIMITED_OBJECTS,
                RAID_FORCE_MAX_HEROS,
                RAID_FORCE_REQUIRED_FACTION,
                WIN_MESSAGE_COLOR,
                LOSE_MESSAGE_COLOR,
                WIN_LOSE_MESSAGE_FONT,
                WIN_LOSE_MESSAGE_FONT_SIZE,
                GAME_PLAY_UI_CREDIT_FONT_NAME,
                GAME_PLAY_UI_CREDIT_FONT_SIZE,
                GAME_PLAY_UI_COUNTDOWN_FONT_NAME,
                GAME_PLAY_UI_COUNTDOWN_FONT_SIZE,
                IN_GAME_MESSAGE_DEFAULT_FONT_NAME,
                IN_GAME_MESSAGE_DEFAULT_FONT_SIZE,
                EVENT_MESSAGE_DEFAULT_FONT_NAME,
                EVENT_MESSAGE_DEFAULT_FONT_SIZE,
                BINK_PLAYER_CAPTION_FONT_NAME,
                BINK_PLAYER_CAPTION_FONT_SIZE,
                TOOL_TIP_FONT_NAME,
                TOOL_TIP_FONT_SIZE,
                TOOL_TIP_SMALL_FONT_NAME,
                TOOL_TIP_SMALL_FONT_SIZE,
                COMMAND_BAR_DEFAULT_FONT_NAME,
                COMMAND_BAR_DEFAULT_FONT_SIZE,
                TEXT_BUTTON_DEFAULT_FONT_NAME,
                TEXT_BUTTON_DEFAULT_FONT_SIZE,
                GAME_OBJECT_NAME_FONT_NAME,
                GAME_OBJECT_NAME_FONT_SIZE,
                BATTLE_PENDING_MESSAGE_COLOR,
                BATTLE_PENDING_MESSAGE_FONT,
                BATTLE_PENDING_MESSAGE_FONT_SIZE,
                BATTLE_PENDING_MESSAGE_POS_X,
                BATTLE_PENDING_MESSAGE_POS_Y,
                MP_DEFAULT_CREDITS,
                MP_DEFAULT_START_TECH_LEVEL,
                MP_DEFAULT_MAX_TECH_LEVEL,
                MP_DEFAULT_ALLOW_AUTO_RESOLVE,
                MP_DEFAULT_GAME_TIMER,
                MP_DEFAULT_WIN_CONDITION,
                MP_DEFAULT_WIN_CONDITION_INT_PARAM,
                MP_DEFAULT_WIN_CONDITION_FLOAT_PARAM,
                MP_DEFAULT_ALLOW_HEROES,
                MP_DEFAULT_ALLOW_SUPERWEAPONS,
                MP_DEFAULT_PRE_BUILT_BASE,
                MP_DEFAULT_ALLOW_RANDOM_EVENTS,
                MP_DEFAULT_FREE_STARTING_UNITS,
                MP_DEFAULT_LAND_TACTICAL_WIN_CONDITION,
                MP_DEFAULT_SPACE_TACTICAL_WIN_CONDITION,
                MULTIPLAYER_LOSING_TEAM_BONUS_CREDIT_PERCENTAGE,
                MAX_BUILD_QUEUE,
                SPACE_TACTICAL_UNIT_CAP,
                TERRAIN_RESURFACE_RAND,
                TERRAIN_RESURFACE_TOLERANCE,
                BASE_SHIELD_DELAY_TIME,
                MIN_GAME_SPEED,
                MAX_GAME_SPEED,
                GAME_SPEED_TRACKBAR_STEPS,
                OBJECT_IMPORTANCE_DECAY_FACTOR,
                UNIT_PRESENCE_RELAXATION_TIME,
                DEMO_ATTRACT_MAPS,
                DEMO_ATTRACT_START_TIMEOUT_SECONDS,
                DEMO_ATTRACT_MAP_CYCLE_DELAY_SECONDS,
                BATTLE_PENDING_TIMEOUT_SECONDS,
                UNDER_CONSTRUCTION_DAMAGE_MULTIPLIER,
                SKIRMISH_BUY_CREDITS,
                SKIRMISH_REINFORCEMENT_DELAY_FRAMES,
                DISTRIBUTE_CREDIT_QUANTUM,
                DIMINISHING_FIREPOWER,
                ION_STORM_SHIELD_DISABLE_TIME,
                NEBULA_ABILITY_DISABLE_TIME,
                FORCE_ABILITY_DISABLE_TIME,
                DEPLETED_SHIELD_DISABLE_TIME,
                DEPLETED_SHIELD_DAMAGE_INCREMENT,
                DEPLETED_SHIELD_REGEN_CAP,
                NEBULA_EFFECT_COLOR,
                BASE_SHIELD_SPEED_MODIFIER,
                BASE_SHIELD_VULNERABILITY_MODIFIER,
                HARDPOINT_RECHARGE_CUTOFF_FOR_OPPORTUNITY_FIRE,
                BATTLE_LOAD_PLANET_VIEWPORT,
                SALIENCY_SIZE,
                SALIENCY_POWER,
                SALIENCY_X,
                SALIENCY_Y,
                SALIENCY_HEALTH,
                SALIENCY_TARGETS,
                SALIENCY_SPEED,
                PLANET_REVEAL_DELAY_TIME,
                BATTLE_LOAD_PLANET_DIRECTION,
                BATTLE_LOAD_PLANET_AMBIENT,
                ACTIVATED_BLACK_MARKET_ABILITY_NAMES,
                ACTIVATED_SLICE_ABILITY_NAMES,
                ACTIVATED_SABOTAGE_ABILITY_NAMES,
                ACTIVATED_NEUTRALIZE_HERO_ABILITY_NAMES,
                ACTIVATED_SIPHON_CREDITS_ABILITY_NAMES,
                ACTIVATED_SYSTEM_SPY_ABILITY_NAMES,
                ACTIVATED_DESTROY_PLANET_ABILITY_NAMES,
                ACTIVATED_CORRUPT_PLANET_ABILITY_NAMES,
                ACTIVATED_REMOVE_CORRUPTION_ABILITY_NAMES,
                ACTIVATED_HACK_SUPER_WEAPON_ABILITY_NAMES,
                USE_REINFORCEMENT_POINTS,
                STRATEGIC_QUEUE_TACTICAL_BATTLES,
                HEALTH_BAR_SCALE,
                LAND_HEALTH_BAR_SCALE,
                MIN_HEALTH_BAR_SCALE,
                CREDITS_SPACING,
                CREDITS_SCROLL_RATE,
                CREDITS_FONT,
                CREDITS_FONT_SIZE,
                CREDITS_ROWS,
                CREDITS_TOP_COLOR,
                CREDITS_BOTTOM_COLOR,
                CREDITS_HEADER_TOP_COLOR,
                CREDITS_HEADER_BOTTOM_COLOR,
                CREDITS_MARGIN,
                CREDITS_LOGO_1_NAME,
                CREDITS_LOGO_1_WIDTH,
                CREDITS_LOGO_1_HEIGHT,
                CREDITS_LOGO_1_Y_OFFSET,
                CREDITS_LOGO_2_NAME,
                CREDITS_LOGO_2_WIDTH,
                CREDITS_LOGO_2_HEIGHT,
                CREDITS_LOGO_2_Y_OFFSET,
                CREDITS_LOGO_3_NAME,
                CREDITS_LOGO_3_WIDTH,
                CREDITS_LOGO_3_HEIGHT,
                CREDITS_LOGO_3_Y_OFFSET,
                TRACTOR_BEAM_WIDTH,
                TRACTOR_BEAM_TEXTURE,
                TRACTOR_BEAM_FRAMES,
                TRACTOR_BEAM_COLOR,
                ENERGY_BEAM_WIDTH,
                ENERGY_BEAM_TEXTURE,
                ENERGY_BEAM_FRAMES,
                ENERGY_BEAM_COLOR,
                TEAM_HEALTHBAR_OFFSET,
                OBJECT_VISUAL_STATUS_PARTICLE_ATTACH_BONE_NAMES,
                MESSAGE_OF_THE_DAY_URL,
                CONTROL_POINT_DOMINATION_VICTORY_TIME_IN_SECS,
                CAMERA_FX_MANAGER_LETTERBOX_HEIGHT,
                HEALTH_LOW_PERCENT_THRESHOLD,
                HEALTH_CRITICAL_PERCENT_THRESHOLD,
                MP_COLOR_BLUE,
                MP_COLOR_RED,
                MP_COLOR_GREEN,
                MP_COLOR_ORANGE,
                MP_COLOR_CYAN,
                MP_COLOR_PURPLE,
                MP_COLOR_YELLOW,
                MP_COLOR_GRAY,
                MP_COLOR_EIGHT,
                MELEE_CUTOFF_RANGE,
                SPACE_RETREAT_ALLOWED_COUNTDOWN_SECONDS,
                LAND_RETREAT_ALLOWED_COUNTDOWN_SECONDS,
                LOCALIZED_SPLASH_SCREEN,
                LOCALIZED_MENU_OVERLAY,
                LOCALIZED_UK_ENGLISH_SPLASH_SCREEN,
                MAIN_MENU_DEMO_ATTRACT_MODE,
                INDIGENOUS_SPAWN_DESTRUCTION_REWARD,
                ADVISOR_HINT_INTERVAL,
                ADVISOR_HINT_DURATION,
                RADAR_COLORIZE_SELECTED_UNITS,
                RADAR_SELECTED_UNITS_COLOR,
                RADAR_COLORIZE_MULTIPLAYER_ENEMY,
                RADAR_MULTIPLAYER_ENEMY_COLOR,
                ANIMATE_DURING_GALACTIC_MODE_PAUSE,
                LAND_BASE_DESTRUCTION_FORCES_RETREAT,
                SPACE_STATION_DESTRUCTION_FORCES_RETREAT,
                LAND_CAPTURE_ALLOWED_COUNTDOWN_SECONDS,
                SPACE_CAPTURE_ALLOWED_COUNTDOWN_SECONDS,
                SPACE_REINFORCEMENT_COLLISION_CHECK_DISTANCE,
                HEALTH_BAR_SPACING,
                MAX_BOMBING_RUN_INTERVAL_SECONDS,
                MIN_BOMBING_RUN_INTERVAL_SECONDS,
                BOMBING_RUN_REDUCTION_PER_SQUADRON_PERCENT,
                MAX_BOMBARD_INTERVAL_SECONDS,
                MIN_BOMBARD_INTERVAL_SECONDS,
                BOMBARDMENT_OFFSET,
                BOMBARDMENT_DISTRIBUTION,
                AI_USES_GALACTIC_POP_CAP,
                SPACE_GUARD_RANGE,
                LAND_GUARD_RANGE,
                OVERRIDE_DEATH_PERSISTENCE_DURATION,
                AUTO_RESOLVE_TACTICAL_MULTIPLIER,
                QUICKMATCH_MAP_EXCLUSION_LIST,
                CORRUPTION_PARTICLE_NAME,
                CORRUPTION_PARTICLE_LINE_NAME,
                PARTICLE_BRIGHTNESS_PER_CORRUPTION_LEVEL,
                PARTICLE_SCALE_PER_CORRUPTION_LEVEL,
                PARTICLE_ENERGY_PER_CORRUPTION_LEVEL,
                CORRUPTION_LINE_RADIUS,
                CORRUPTION_LINE_START_END_OFFSET,
                CORRUPTION_LINE_GROW_SECONDS,
                CORRUPTION_PATH_COLOR,
                CORRUPTION_PATH_WIDTH,
                CORRUPTION_PATH_OFFSET,
                BRIBERY_FLEET_REVEAL_RANGE,
                SABOTAGE_PARTICLE_EFFECT,
                HACK_SUPER_WEAPON_PARTICLE_EFFECT,
                HACK_SUPER_WEAPON_REQUIRED_TYPE,
                SENSOR_JAMMING_TIME,
                STEALTH_DETECTION_TIME,
                FIRST_STRIKE_EXTRA_DAMAGE_PERCENT,
                FIRST_STRIKE_PARTICLE,
                GARRISONED_MAX_ATTACK_DISTANCE_MULTIPLIER,
                PATHFINDER_SLOT_INDEX,
                DEFAULT_BOUNTY_BY_CATEGORY_SP,
                DEFAULT_BOUNTY_BY_CATEGORY_MP,
                MAX_REMOTE_BOMBS_PER_PLAYER,
                CORRUPTION_HYPERSPACE_BONUS,
                CORRUPTION_CHOICE_ICON_NAME,
                CORRUPTION_CHOICE_NAME,
                CORRUPTION_CHOICE_BENEFIT,
                CORRUPTION_MISSION_REQUIREMENT_ICON_NAME,
                CORRUPTION_CHOICE_ENCYCLOPEDIA,
                CORRUPTION_CHOICE_INCOME_PERCENTAGE,
                CORRUPTION_PLANET_ICON,
                CORRUPTION_PLANET_ICON_ENCYCLOPEDIA_NAME,
                CORRUPTION_PLANET_ICON_ENCYCLOPEDIA_DESC,
                HACK_SUPER_WEAPON_COST,
                CORRUPTION_ENCYCLOPEDIA_BACKDROP,
                CORRUPTION_ENCYCLOPEDIA_HEADER,
                CORRUPTION_ENCYCLOPEDIA_COMPLETE,
                CORRUPTION_ENCYCLOPEDIA_INCOMPLETE,
                CORRUPTION_ENCYCLOPEDIA_MONEY_ICON,
                CORRUPTION_ENCYCLOPEDIA_LEFT_EDGE,
                CORRUPTION_ENCYCLOPEDIA_SPACING,
            };
        }

        internal const string DEFAULT_DEFENSE_ADJUST = "Default_Defense_Adjust";
        internal const string STARTING_GALACTIC_CAMERA_POSITION = "Starting_Galactic_Camera_Position";
        internal const string CAMERA_STOP_LEFT = "Camera_Stop_Left";
        internal const string CAMERA_STOP_RIGHT = "Camera_Stop_Right";
        internal const string CAMERA_Z_POSITION = "Camera_Z_Position";
        internal const string FLEET_MOVEMENT_LINE_TEXTURE_NAME = "Fleet_Movement_Line_Texture_Name";
        internal const string FLEET_HYPERSPACE_BAND_TEXTURE_NAME = "Fleet_Hyperspace_Band_Texture_Name";
        internal const string LOOPWAYPOINTLINETEXTURENAME = "LoopWaypointLineTextureName";
        internal const string WAYPOINTLINETEXTURENAME = "WaypointLineTextureName";
        internal const string WAYPOINTFLAGMODELNAME = "WaypointFlagModelName";
        internal const string FLEET_MAINTENANCE_UPDATE_DELAY_SECONDS = "Fleet_Maintenance_Update_Delay_Seconds";
        internal const string PAY_AS_YOU_GO = "Pay_As_You_Go";
        internal const string USE_NEUTRAL_UI_COLOR = "Use_Neutral_UI_Color";
        internal const string NEUTRAL_UI_COLOR = "Neutral_UI_Color";
        internal const string PLAYER_COLOR = "Player_Color";
        internal const string ENEMY_COLOR = "Enemy_Color";
        internal const string SPACE_AUTO_RESOLVE_DELAY_SECONDS = "Space_Auto_Resolve_Delay_Seconds";
        internal const string LAND_AUTO_RESOLVE_DELAY_SECONDS = "Land_Auto_Resolve_Delay_Seconds";
        internal const string PRODUCTION_SPEED_FACTOR = "Production_Speed_Factor";
        internal const string POLITICAL_CONTROL_CHANGE_TIME_SECONDS = "Political_Control_Change_Time_Seconds";
        internal const string POLITICAL_INCOME_CURVE = "Political_Income_Curve";
        internal const string PROGRESSIVE_TAXATION = "Progressive_Taxation";
        internal const string INCOME_REDISTRIBUTION = "Income_Redistribution";
        internal const string CREDIT_CAP_PER_PLANET = "Credit_Cap_Per_Planet";
        internal const string FISCAL_CYCLE_TIME_IN_SECS = "Fiscal_Cycle_Time_In_Secs";
        internal const string MEDIUM_COIN_STACK_SIZE = "Medium_Coin_Stack_Size";
        internal const string LARGE_COIN_STACK_SIZE = "Large_Coin_Stack_Size";
        internal const string BLACK_MARKET_INCOME_MULT_MIN = "Black_Market_Income_Mult_Min";
        internal const string BLACK_MARKET_INCOME_MULT_MAX = "Black_Market_Income_Mult_Max";
        internal const string NUM_STRUCTURES_FOR_MEDIUM_PLANET_NAME = "Num_Structures_For_Medium_Planet_Name";
        internal const string NUM_STRUCTURES_FOR_LARGE_PLANET_NAME = "Num_Structures_For_Large_Planet_Name";
        internal const string MAXIMUMPOLITICALCONTROL = "MaximumPoliticalControl";
        internal const string MAXIMUMSTARBASELEVEL = "MaximumStarbaseLevel";
        internal const string MAXIMUMGROUNDBASELEVEL = "MaximumGroundbaseLevel";
        internal const string MAXIMUMSPECIALSTRUCTURES = "MaximumSpecialStructures";
        internal const string MAXIMUMSPECIALSTRUCTURESLAND = "MaximumSpecialStructuresLand";
        internal const string MAXIMUMSPECIALSTRUCTURESSPACE = "MaximumSpecialStructuresSpace";
        internal const string MAXIMUMFLEETMOVEMENTDISTANCE = "MaximumFleetMovementDistance";
        internal const string SHIPNAMETEXTFILES = "ShipNameTextFiles";
        internal const string TRADEROUTEMOVEMENTFACTOR = "TradeRouteMovementFactor";
        internal const string GMC_INITIALPITCHANGLEDEGREES = "GMC_InitialPitchAngleDegrees";
        internal const string GMC_ZOOMEDPITCHANGLEDEGREES = "GMC_ZoomedPitchAngleDegrees";
        internal const string GMC_INITIALPULLBACKDISTANCE = "GMC_InitialPullbackDistance";
        internal const string GMC_ZOOMEDPULLBACKPLANETRADIUSFRACTION = "GMC_ZoomedPullbackPlanetRadiusFraction";

        internal const string GMC_ZOOMEDPOSITIONOFFSETPLANETRADIUSFRACTIONS =
            "GMC_ZoomedPositionOffsetPlanetRadiusFractions";

        internal const string GMC_ZOOMTIME = "GMC_ZoomTime";
        internal const string GMC_BATTLE_ZOOM_TIME = "GMC_Battle_Zoom_Time";
        internal const string GMC_BATTLE_FADE_TIME = "GMC_Battle_Fade_Time";
        internal const string GALACTIC_RIGHT_BUTTON_SCROLL_SPEED_FACTOR = "Galactic_Right_Button_Scroll_Speed_Factor";
        internal const string GALACTIC_SCROLL_PLANE = "Galactic_Scroll_Plane";
        internal const string PUSH_SCROLL_SPEED_MODIFIER = "Push_Scroll_Speed_Modifier";
        internal const string SCROLL_DECELERATION_FACTOR = "Scroll_Deceleration_Factor";
        internal const string SCROLL_ACCELERATION_FACTOR = "Scroll_Acceleration_Factor";
        internal const string GUI_MOVE_COMMAND_ACK_EFFECT = "GUI_Move_Command_Ack_Effect";
        internal const string GUI_DOUBLE_CLICK_MOVE_COMMAND_ACK_EFFECT = "GUI_Double_Click_Move_Command_Ack_Effect";
        internal const string GUI_ATTACK_MOVE_COMMAND_ACK_EFFECT = "GUI_Attack_Move_Command_Ack_Effect";
        internal const string GUI_GUARD_MOVE_COMMAND_ACK_EFFECT = "GUI_Guard_Move_Command_Ack_Effect";
        internal const string GUI_ATTACK_MOVEMENT_CLICK_RADAR_EVENT_NAME = "GUI_Attack_Movement_Click_Radar_Event_Name";
        internal const string GUI_MOVEMENT_CLICK_RADAR_EVENT_NAME = "GUI_Movement_Click_Radar_Event_Name";
        internal const string GUI_MOVEMENT_DOUBLE_CLICK_RADAR_EVENT_NAME = "GUI_Movement_Double_Click_Radar_Event_Name";
        internal const string GUI_MOVE_ACKNOWLEDGE_SCALE_LAND = "GUI_Move_Acknowledge_Scale_Land";
        internal const string GUI_MOVE_ACKNOWLEDGE_SCALE_SPACE = "GUI_Move_Acknowledge_Scale_Space";
        internal const string TOOLTIP_DELAY = "Tooltip_Delay";
        internal const string TEXT_REVEAL_RATE = "Text_Reveal_Rate";
        internal const string ENCYCLOPEDIA_DELAY = "Encyclopedia_Delay";
        internal const string LONG_ENCYCLOPEDIA_DELAY = "Long_Encyclopedia_Delay";
        internal const string MAP_PREVIEW_IMAGE_SIZE = "Map_Preview_Image_Size";
        internal const string JAPANESE_ST_LINE_PERCENT = "Japanese_ST_Line_Percent";
        internal const string ELEVATED_VULNERABILITY_DURATION = "Elevated_Vulnerability_Duration";
        internal const string ELEVATED_VULNERABILITY_FACTOR = "Elevated_Vulnerability_Factor";
        internal const string SPACE_ELEVATED_VULNERABILITY_DURATION = "Space_Elevated_Vulnerability_Duration";
        internal const string SPACE_ELEVATED_VULNERABILITY_FACTOR = "Space_Elevated_Vulnerability_Factor";
        internal const string TELEKINESIS_HOVER_HEIGHT = "Telekinesis_Hover_Height";
        internal const string TELEKINESIS_TRANSITION_TIME = "Telekinesis_Transition_Time";
        internal const string TELEKINESIS_WOBBLE_CYCLE_TIME = "Telekinesis_Wobble_Cycle_Time";
        internal const string TELEKINESIS_WOBBLE_FADE_TIME = "Telekinesis_Wobble_Fade_Time";
        internal const string TELEKINESIS_MAX_WOBBLE_ANGLE = "Telekinesis_Max_Wobble_Angle";
        internal const string TELEKINESIS_MAX_BOB_HEIGHT = "Telekinesis_Max_Bob_Height";
        internal const string EARTHQUAKE_TRANSITION_TIME = "Earthquake_Transition_Time";
        internal const string EARTHQUAKE_SHAKE_SPEED = "Earthquake_Shake_Speed";
        internal const string EARTHQUAKE_SHAKE_MAGNITUDE = "Earthquake_Shake_Magnitude";
        internal const string AIUSESFOGOFWARGALACTIC = "AIUsesFogOfWarGalactic";
        internal const string AIUSESFOGOFWARSPACE = "AIUsesFogOfWarSpace";
        internal const string AIUSESFOGOFWARLAND = "AIUsesFogOfWarLand";
        internal const string SETUPPHASEENABLED = "SetupPhaseEnabled";
        internal const string ALWAYSBYPASSAUTORESOLVE = "AlwaysBypassAutoResolve";
        internal const string AUTOMATICAUTORESOLVE = "AutomaticAutoResolve";
        internal const string AUTORESOLVEVOTEDEFAULTTOTACTICAL = "AutoResolveVoteDefaultToTactical";
        internal const string AUTORESOLVEVOTEDEFAULTTIMEOUT = "AutoResolveVoteDefaultTimeOut";
        internal const string PLAYMODESWITCHMOVIES = "PlayModeSwitchMovies";
        internal const string SHIELDRECHARGEINTERVALINSECS = "ShieldRechargeIntervalInSecs";
        internal const string ENERGYRECHARGEINTERVALINSECS = "EnergyRechargeIntervalInSecs";
        internal const string ENERGYTOSHIELDEXCHANGERATE = "EnergyToShieldExchangeRate";
        internal const string MAXINFLUENCETRANSITIONALIGNMENTBONUS = "MaxInfluenceTransitionAlignmentBonus";
        internal const string MAXINFLUENCETRANSITIONALIGNMENTPENALTY = "MaxInfluenceTransitionAlignmentPenalty";
        internal const string MAXCREDITINCOMEALIGNMENTBONUS = "MaxCreditIncomeAlignmentBonus";
        internal const string MAXCREDITINCOMEALIGNMENTPENALTY = "MaxCreditIncomeAlignmentPenalty";
        internal const string MAXCOMBATACCURACYALIGNMENTBONUS = "MaxCombatAccuracyAlignmentBonus";
        internal const string MAXCOMBATDAMAGEALIGNMENTBONUS = "MaxCombatDamageAlignmentBonus";
        internal const string MAXCOMBATSENSORRANGEALIGNMENTBONUS = "MaxCombatSensorRangeAlignmentBonus";
        internal const string MAX_GALACTIC_ZOOM_DISTANCE = "Max_Galactic_Zoom_Distance";
        internal const string MIN_GALACTIC_ZOOM_SPEED = "Min_Galactic_Zoom_Speed";
        internal const string MAX_GALACTIC_ZOOM_SPEED = "Max_Galactic_Zoom_Speed";
        internal const string GALACTIC_ZOOM_ACCELERATION = "Galactic_Zoom_Acceleration";
        internal const string GALACTIC_ZOOM_LIGHT_LEVEL = "Galactic_Zoom_Light_Level";
        internal const string GALACTIC_ZOOM_IN_LIGHT_ANGLE = "Galactic_Zoom_In_Light_Angle";
        internal const string GALACTIC_ZOOM_OUT_LIGHT_ANGLE = "Galactic_Zoom_Out_Light_Angle";
        internal const string GALACTIC_ZOOM_IN_STATION_OFFSET = "Galactic_Zoom_In_Station_Offset";
        internal const string GALACTIC_ZOOM_IN_STATION_ROTATION = "Galactic_Zoom_In_Station_Rotation";
        internal const string RANDOM_STORY_TRIGGERS = "Random_Story_Triggers";
        internal const string RANDOM_STORY_MAX_TRIGGERS = "Random_Story_Max_Triggers";
        internal const string RANDOM_STORY_REBEL_CONSTRUCTION = "Random_Story_Rebel_Construction";
        internal const string RANDOM_STORY_EMPIRE_CONSTRUCTION = "Random_Story_Empire_Construction";
        internal const string RANDOM_STORY_REBEL_DESTROY = "Random_Story_Rebel_Destroy";
        internal const string RANDOM_STORY_EMPIRE_DESTROY = "Random_Story_Empire_Destroy";
        internal const string RANDOM_STORY_REWARDS = "Random_Story_Rewards";
        internal const string RANDOM_STORY_REWARD_REBEL_BUILDABLE = "Random_Story_Reward_Rebel_Buildable";
        internal const string RANDOM_STORY_REWARD_EMPIRE_BUILDABLE = "Random_Story_Reward_Empire_Buildable";
        internal const string RANDOM_STORY_REWARD_REBEL_UNIT = "Random_Story_Reward_Rebel_Unit";
        internal const string RANDOM_STORY_REWARD_EMPIRE_UNIT = "Random_Story_Reward_Empire_Unit";
        internal const string MAX_GROUND_FORCES_ON_PLANET = "Max_Ground_Forces_On_Planet";
        internal const string ALLOW_REINFORCEMENT_PERCENTAGE_NORMALIZED = "Allow_Reinforcement_Percentage_Normalized";
        internal const string TACTICAL_EDGE_SCROLL_REGION = "Tactical_Edge_Scroll_Region";
        internal const string TACTICAL_MAX_SCROLL_SPEED = "Tactical_Max_Scroll_Speed";
        internal const string TACTICAL_MIN_SCROLL_SPEED = "Tactical_Min_Scroll_Speed";
        internal const string TACTICAL_OFFSCREEN_SCROLL_REGION = "Tactical_Offscreen_Scroll_Region";
        internal const string STRATEGIC_EDGE_SCROLL_REGION = "Strategic_Edge_Scroll_Region";
        internal const string STRATEGIC_MAX_SCROLL_SPEED = "Strategic_Max_Scroll_Speed";
        internal const string STRATEGIC_MIN_SCROLL_SPEED = "Strategic_Min_Scroll_Speed";
        internal const string STRATEGIC_OFFSCREEN_SCROLL_REGION = "Strategic_Offscreen_Scroll_Region";
        internal const string HARDPOINT_TARGET_RETICLE_ENEMY_SCREEN_SIZE = "HardPoint_Target_Reticle_Enemy_Screen_Size";

        internal const string HARDPOINT_TARGET_RETICLE_FRIENDLY_SCREEN_SIZE =
            "HardPoint_Target_Reticle_Friendly_Screen_Size";

        internal const string HARDPOINT_TARGET_RETICLE_ENEMY_TEXTURE = "HardPoint_Target_Reticle_Enemy_Texture";

        internal const string HARDPOINT_TARGET_RETICLE_ENEMY_TRACKED_TEXTURE =
            "HardPoint_Target_Reticle_Enemy_Tracked_Texture";

        internal const string HARDPOINT_TARGET_RETICLE_FRIENDLY_TEXTURE = "HardPoint_Target_Reticle_Friendly_Texture";

        internal const string HARDPOINT_TARGET_RETICLE_FRIENDLY_TRACKED_TEXTURE =
            "HardPoint_Target_Reticle_Friendly_Tracked_Texture";

        internal const string HARDPOINT_TARGET_RETICLE_FRIENDLY_REPAIRING_TEXTURE =
            "HardPoint_Target_Reticle_Friendly_Repairing_Texture";

        internal const string HARDPOINT_TARGET_RETICLE_FRIENDLY_DISABLED_TEXTURE =
            "HardPoint_Target_Reticle_Friendly_Disabled_Texture";

        internal const string HARDPOINT_TARGET_RETICLE_FRIENDLY_DISABLED_TRACKED_TEXTURE =
            "HardPoint_Target_Reticle_Friendly_Disabled_Tracked_Texture";

        internal const string DEBUG_HOT_KEY_LOAD_MAP = "Debug_Hot_Key_Load_Map";
        internal const string DEBUG_HOT_KEY_LOAD_MAP_SCRIPT = "Debug_Hot_Key_Load_Map_Script";
        internal const string DEBUG_HOT_KEY_LOAD_CAMPAIGN = "Debug_Hot_Key_Load_Campaign";
        internal const string GAME_SCORING_SCRIPT_NAME = "Game_Scoring_Script_Name";
        internal const string SHOWUNITAIPLANATTACHMENT = "ShowUnitAIPlanAttachment";
        internal const string AI_SPACEEVALUATORREGIONSIZE = "AI_SpaceEvaluatorRegionSize";
        internal const string AI_LANDEVALUATORREGIONSIZE = "AI_LandEvaluatorRegionSize";
        internal const string AI_SPACETHREATDISTANCEFACTOR = "AI_SpaceThreatDistanceFactor";
        internal const string AI_LANDTHREATDISTANCEFACTOR = "AI_LandThreatDistanceFactor";
        internal const string AI_SPACETHREATTURNRATEFACTOR = "AI_SpaceThreatTurnRateFactor";
        internal const string AI_LANDTHREATTURNRATEFACTOR = "AI_LandThreatTurnRateFactor";
        internal const string AI_SPACETHREATLOOKAHEADTIME = "AI_SpaceThreatLookAheadTime";
        internal const string AI_LANDTHREATLOOKAHEADTIME = "AI_LandThreatLookAheadTime";
        internal const string AI_SPACEAREATHREATSCALEFACTOR = "AI_SpaceAreaThreatScaleFactor";
        internal const string AI_LANDAREATHREATSCALEFACTOR = "AI_LandAreaThreatScaleFactor";
        internal const string AI_FOGCELLSPERTHREATCELL = "AI_FogCellsPerThreatCell";
        internal const string AI_SPACETHREATDECAYSTEP = "AI_SpaceThreatDecayStep";
        internal const string AI_BUILDTASKRESERVATIONSECONDS = "AI_BuildTaskReservationSeconds";
        internal const string AI_LANDTHREATRANGECAP = "AI_LandThreatRangeCap";
        internal const string AI_SPACETHREATRANGECAP = "AI_SpaceThreatRangeCap";
        internal const string SPACEFOWCOLOR = "SpaceFOWColor";
        internal const string LANDFOWCOLOR = "LandFOWColor";
        internal const string SPACEREINFORCEFOWCOLOR = "SpaceReinforceFOWColor";
        internal const string SETUPPHASEFOWCOLOR = "SetupPhaseFOWColor";
        internal const string SETUPPHASEINVALIDDRAGCOLOR = "SetupPhaseInvalidDragColor";
        internal const string SETUPPHASECOUNTDOWNSECONDS = "SetupPhaseCountdownSeconds";
        internal const string SPACEFOWHEIGHT = "SpaceFOWHeight";
        internal const string GOOD_GROUND_COLOR_TINT = "Good_Ground_Color_Tint";
        internal const string RETREAT_COLOR_TINT = "Retreat_Color_Tint";
        internal const string HIGH_GROUND_COLOR_TINT = "High_Ground_Color_Tint";
        internal const string SLOW_GROUND_COLOR_TINT = "Slow_Ground_Color_Tint";
        internal const string LAVA_GROUND_COLOR_TINT = "Lava_Ground_Color_Tint";
        internal const string INFANTRY_GROUND_COLOR_TINT = "Infantry_Ground_Color_Tint";
        internal const string DESIREDLANDFOWCELLSIZE = "DesiredLandFOWCellSize";
        internal const string DESIREDSPACEFOWCELLSIZE = "DesiredSpaceFOWCellSize";
        internal const string LANDFOWREGROWTIME = "LandFOWRegrowTime";
        internal const string SPACEFOWREGROWTIME = "SpaceFOWRegrowTime";
        internal const string SPACEREINFORCEFEEDBACKONLYWHILEDRAGGING = "SpaceReinforceFeedbackOnlyWhileDragging";
        internal const string WATER_RENDER_TARGET_RESOLUTION = "Water_Render_Target_Resolution";
        internal const string WATER_CLIP_PLANE_OFFSET = "Water_Clip_Plane_Offset";
        internal const string OCCLUSION_SILHOUETTES_ENABLED = "Occlusion_Silhouettes_Enabled";
        internal const string LASER_BEAM_Z_SCALE_FACTOR = "Laser_Beam_Z_Scale_Factor";
        internal const string LASER_KITE_Z_SCALE_FACTOR = "Laser_Kite_Z_Scale_Factor";
        internal const string MOUSE_OVER_HIGHLIGHT_SCALE = "Mouse_Over_Highlight_Scale";
        internal const string DEFAULT_HERO_RESPAWN_TIME = "Default_Hero_Respawn_Time";
        internal const string MINIMUMDRAGDISTANCE = "MinimumDragDistance";
        internal const string MINIMUMDRAGSELECTDISTANCE = "MinimumDragSelectDistance";
        internal const string SPACEPATHFINDMAXEXPANSIONS = "SpacePathfindMaxExpansions";
        internal const string CURRENTPATHCOSTCOEFFICIENTSPACE = "CurrentPathCostCoefficientSpace";
        internal const string SPACEPATHFINDFRAMEDELAYDELTA = "SpacePathfindFrameDelayDelta";
        internal const string SPACEPATHFAILUREDISTANCECUTOFFCOEFFICIENT = "SpacePathFailureDistanceCutoffCoefficient";
        internal const string SPACEPATHFAILUREMAXEXPANSIONSCOEFFICIENT = "SpacePathFailureMaxExpansionsCoefficient";
        internal const string SPACEPATHFAILUREROTATIONEXPANSIONINCREMENT = "SpacePathFailureRotationExpansionIncrement";
        internal const string SPACEPATHFAILUREFORWARDEXPANSIONINCREMENT = "SpacePathFailureForwardExpansionIncrement";
        internal const string SPACEPATHINGTRIES = "SpacePathingTries";
        internal const string SPACESTATICOBSTACLEAVOIDANCEBONUSDISTANCE = "SpaceStaticObstacleAvoidanceBonusDistance";
        internal const string MINOBSTACLECOSTSPACE = "MinObstacleCostSpace";
        internal const string MAXOBSTACLECOSTSPACE = "MaxObstacleCostSpace";
        internal const string OBSTACLEAREAOVERLAPFORMAXSPACE = "ObstacleAreaOverlapForMaxSpace";
        internal const string XYEXPANSIONDISTANCESPACE = "XYExpansionDistanceSpace";
        internal const string MAXROTATIONSSPACE = "MaxRotationsSpace";
        internal const string MATCHFACINGDELTASPACE = "MatchFacingDeltaSpace";
        internal const string OCCUPATIONRADIUSCOEFFICIENTSPACE = "OccupationRadiusCoefficientSpace";
        internal const string DESTINATIONSEARCHRADIUSINCREMENTSPACE = "DestinationSearchRadiusIncrementSpace";
        internal const string USELINEARCOLLISIONCHECKS = "UseLinearCollisionChecks";
        internal const string WAITOPERATORCOSTCOEFFICIENT = "WaitOperatorCostCoefficient";
        internal const string WAITOPERATORBASEFRAMETIME = "WaitOperatorBaseFrameTime";
        internal const string WAITOPERATORSPEEDCOEFFICIENT = "WaitOperatorSpeedCoefficient";
        internal const string LANDWAITOPERATORSPEEDCOEFFICIENT = "LandWaitOperatorSpeedCoefficient";
        internal const string SPACELOCOMOTORFACINGLOOKAHEADACC = "SpaceLocomotorFacingLookaheadAcc";
        internal const string FINALFACING180PENALTY = "FinalFacing180Penalty";
        internal const string SPECIALALIGNEDOPERATORBONUS = "SpecialAlignedOperatorBonus";
        internal const string THREATEXPANSIONDISTANCE = "ThreatExpansionDistance";
        internal const string OFFMAPCOSTPENALTY = "OffMapCostPenalty";
        internal const string MAXLANDFORMATIONFORMUPFRAMES = "MaxLandFormationFormupFrames";
        internal const string MOVEMENTREEVALUATIONFRAMECOUNT = "MovementReevaluationFrameCount";
        internal const string ASTEROID_FIELD_DAMAGE = "Asteroid_Field_Damage";
        internal const string ASTEROID_FIELD_DAMAGE_RATE = "Asteroid_Field_Damage_Rate";
        internal const string GUI_FLASH_LEVEL = "GUI_Flash_Level";
        internal const string GUI_FLASH_DURATION = "GUI_Flash_Duration";
        internal const string GUI_RAPID_FLASH_DURATION = "GUI_Rapid_Flash_Duration";
        internal const string GUI_CYCLE_SPEED = "GUI_Cycle_Speed";
        internal const string GUI_DARKEN_LEVEL = "GUI_Darken_Level";
        internal const string GUI_CYCLE_COLOR = "GUI_Cycle_Color";
        internal const string GUI_HILITE_LEVEL = "GUI_Hilite_Level";
        internal const string GUI_PLANET_FLASH_LEVEL = "GUI_Planet_Flash_Level";
        internal const string GUI_PLANET_FADE_DURATION = "GUI_Planet_Fade_Duration";
        internal const string CB_FLASH_DURATION = "CB_Flash_Duration";
        internal const string CB_FLASH_COUNT = "CB_Flash_Count";
        internal const string ICONS_PER_COLUMN = "Icons_Per_Column";
        internal const string HINT_TEXT_COLOR = "Hint_Text_Color";
        internal const string SYSTEM_TEXT_COLOR = "System_Text_Color";
        internal const string TASK_TEXT_COLOR = "Task_Text_Color";
        internal const string SPEECH_TEXT_COLOR = "Speech_Text_Color";
        internal const string DROID_TEXT_COLOR = "Droid_Text_Color";
        internal const string DROID_DATE_COLOR = "Droid_Date_Color";
        internal const string DROID_SEPERATOR_COLOR = "Droid_Seperator_Color";
        internal const string CB_MOVIE_OFFSET = "CB_Movie_Offset";
        internal const string CB_MOVIE_COLOR = "CB_Movie_Color";
        internal const string GOOD_SIDE_NAME = "Good_Side_Name";
        internal const string EVIL_SIDE_NAME = "Evil_Side_Name";
        internal const string CORRUPT_SIDE_NAME = "Corrupt_Side_Name";
        internal const string GOOD_SIDE_LEADER_NAME = "Good_Side_Leader_Name";
        internal const string EVIL_SIDE_LEADER_NAME = "Evil_Side_Leader_Name";
        internal const string CORRUPT_SIDE_LEADER_NAME = "Corrupt_Side_Leader_Name";
        internal const string ENCYCLOPEDIA_POPULATION_OFFSET = "Encyclopedia_Population_Offset";
        internal const string ENCYCLOPEDIA_NAME_OFFSET = "Encyclopedia_Name_Offset";
        internal const string ENCYCLOPEDIA_COST_OFFSET = "Encyclopedia_Cost_Offset";
        internal const string ENCYCLOPEDIA_ICON_X_OFFSET = "Encyclopedia_Icon_X_Offset";
        internal const string ENCYCLOPEDIA_ICON_Y_OFFSET = "Encyclopedia_Icon_Y_Offset";
        internal const string ENCYCLOPEDIA_CLASS_Y_OFFSET = "Encyclopedia_Class_Y_Offset";
        internal const string ENCYCLOPEDIA_FADE_RATE = "Encyclopedia_Fade_Rate";
        internal const string ENCYCLOPEDIA_MIN_DISPLAY_TIME = "Encyclopedia_Min_Display_Time";
        internal const string MIN_ACCURACY_FOR_ICON = "Min_Accuracy_For_Icon";
        internal const string MIN_SIGHT_RANGE_FOR_ICON = "Min_Sight_Range_For_Icon";
        internal const string LEFT_QUEUE_TINT = "Left_Queue_Tint";
        internal const string RIGHT_QUEUE_TINT = "Right_Queue_Tint";
        internal const string GUI_TACTICAL_COUNTDOWN_TIMERS_SCREEN_X = "GUI_Tactical_Countdown_Timers_Screen_X";
        internal const string GUI_TACTICAL_COUNTDOWN_TIMERS_SCREEN_Y = "GUI_Tactical_Countdown_Timers_Screen_Y";

        internal const string GUI_TACTICAL_COUNTDOWN_TIMERS_SCREEN_SPACING =
            "GUI_Tactical_Countdown_Timers_Screen_Spacing";

        internal const string GUI_STRATEGIC_COUNTDOWN_TIMERS_SCREEN_X = "GUI_Strategic_Countdown_Timers_Screen_X";
        internal const string GUI_STRATEGIC_COUNTDOWN_TIMERS_SCREEN_Y = "GUI_Strategic_Countdown_Timers_Screen_Y";

        internal const string GUI_STRATEGIC_COUNTDOWN_TIMERS_SCREEN_SPACING =
            "GUI_Strategic_Countdown_Timers_Screen_Spacing";

        internal const string BEACONPLACEDELAY = "BeaconPlaceDelay";
        internal const string WAYPOINTLINELANDDASHLENGTH = "WaypointLineLandDashLength";
        internal const string WAYPOINTLINELANDGAPLENGTH = "WaypointLineLandGapLength";
        internal const string WAYPOINTLINELANDDASHVELOCITY = "WaypointLineLandDashVelocity";
        internal const string MAXWAYPOINTSPERPATH = "MaxWaypointsPerPath";
        internal const string IDLEWALKBLENDTIME = "IdleWalkBlendTime";
        internal const string CROUCHIDLEWALKBLENDTIME = "CrouchIdleWalkBlendTime";
        internal const string MOVEBLENDTIME = "MoveBlendTime";
        internal const string CROUCHMOVEBLENDTIME = "CrouchMoveBlendTime";
        internal const string TEAMMOVEBLENDTIME = "TeamMoveBlendTime";
        internal const string TEAMCROUCHMOVEBLENDTIME = "TeamCrouchMoveBlendTime";
        internal const string INFANTRYTURNBLENDTIME = "InfantryTurnBlendTime";
        internal const string SPACEOBJECTTRACKINGINTERVAL = "SpaceObjectTrackingInterval";
        internal const string LANDOBJECTTRACKINGINTERVAL = "LandObjectTrackingInterval";
        internal const string SPACEOBJECTTRACKINGTREECOUNT = "SpaceObjectTrackingTreeCount";
        internal const string LANDOBJECTTRACKINGTREECOUNT = "LandObjectTrackingTreeCount";
        internal const string MINOBSTACLECOSTLAND = "MinObstacleCostLand";
        internal const string MAXOBSTACLECOSTLAND = "MaxObstacleCostLand";
        internal const string XYEXPANSIONDISTANCELAND = "XYExpansionDistanceLand";
        internal const string SHOULDDISPLAYPREDICTIONPATHS = "ShouldDisplayPredictionPaths";
        internal const string SHOULDDISPLAYSYNCEDPATHS = "ShouldDisplaySyncedPaths";
        internal const string SYNCEDFRAMEINTERVAL = "SyncedFrameInterval";
        internal const string LANDPREDICTIONTIMEINTERVAL = "LandPredictionTimeInterval";
        internal const string REPUSHDISTANCE = "RepushDistance";
        internal const string MINLANDPREDICTIONDISTANCE = "MinLandPredictionDistance";
        internal const string SHOULDSKIPLANDFORMUP = "ShouldSkipLandFormup";
        internal const string SHOULDINFANTRYTEAMSSPLITACROSSFORMATIONS = "ShouldInfantryTeamsSplitAcrossFormations";
        internal const string VEHICLEFORMATIONRECRUITMENTDISTANCE = "VehicleFormationRecruitmentDistance";
        internal const string INFANTRYFORMATIONRECRUITMENTDISTANCE = "InfantryFormationRecruitmentDistance";
        internal const string FRAMESPERCOLLISIONCHECK = "FramesPerCollisionCheck";
        internal const string CLOSEENOUGHANGLEFORMOVESTART = "CloseEnoughAngleForMoveStart";
        internal const string DYNAMICOBSTACLEOVERLAPPENALTY = "DynamicObstacleOverlapPenalty";
        internal const string DYNAMICAVOIDANCERECTANGLEBOUND = "DynamicAvoidanceRectangleBound";
        internal const string SHOULDDISPLAYPOTENTIALPATH = "ShouldDisplayPotentialPath";
        internal const string TURNINPLACESLOWDOWNCORVETTE = "TurnInPlaceSlowdownCorvette";
        internal const string TURNINPLACESLOWDOWNFRIGATE = "TurnInPlaceSlowdownFrigate";
        internal const string TURNINPLACESLOWDOWNCAPITAL = "TurnInPlaceSlowdownCapital";
        internal const string FORMATIONMINIMUMSIDEERROR = "FormationMinimumSideError";
        internal const string FORMATIONMAXIMUMSIDEERROR = "FormationMaximumSideError";
        internal const string APPROXIMATIONSMOOTHCOSANGLE = "ApproximationSmoothCosAngle";
        internal const string APPROXIMATIONFORWARDDISTANCE = "ApproximationForwardDistance";
        internal const string MINIMUMSTOPPEDVSSTOPPEDOVERLAPCOEFFICIENT = "MinimumStoppedVsStoppedOverlapCoefficient";
        internal const string MOVINGVSMOVINGLOOKAHEADTIME = "MovingVsMovingLookAheadTime";
        internal const string LANDDESTINATIONPROXIMITY = "LandDestinationProximity";
        internal const string LANDTEMPORARYDESTINATIONPROXIMITY = "LandTemporaryDestinationProximity";
        internal const string BETWEENFORMATIONSPACING = "BetweenFormationSpacing";
        internal const string PREFERRED_PATHFINDER_TYPES = "Preferred_Pathfinder_Types";
        internal const string DESTINATION_COLLISION_QUERY_EXTENSION = "Destination_Collision_Query_Extension";
        internal const string FRAMESPERPOSITIONAPPROXIMATIONREBUILD = "FramesPerPositionApproximationRebuild";
        internal const string DYNAMICLANDCOMPLEXITYQUOTA = "DynamicLandComplexityQuota";
        internal const string DYNAMICLANDQUOTARESETINTERVAL = "DynamicLandQuotaResetInterval";
        internal const string FINALFORMATIONFACINGMINIMUMANGLE = "FinalFormationFacingMinimumAngle";
        internal const string FINALFORMATIONFACINGDELTACOEFFICIENT = "FinalFormationFacingDeltaCoefficient";
        internal const string WALKANIMATIONCUTOFF = "WalkAnimationCutoff";
        internal const string DOUBLECLICKMOVEMAXSPEEDRATIO = "DoubleClickMoveMaxSpeedRatio";
        internal const string FLEEING_INFANTRY_SPEED_BONUS = "Fleeing_Infantry_Speed_Bonus";
        internal const string SHIELD_FLASH_SCALE = "Shield_Flash_Scale";
        internal const string SHIELD_FLASH_DURATION = "Shield_Flash_Duration";
        internal const string HULL_VS_HARD_POINTS_HEALTH_CONSTRAINT = "Hull_Vs_Hard_Points_Health_Constraint";
        internal const string LOW_THREAT_REACHABILITY_TOLERANCE = "Low_Threat_Reachability_Tolerance";
        internal const string MEDIUM_THREAT_REACHABILITY_TOLERANCE = "Medium_Threat_Reachability_Tolerance";
        internal const string HIGH_THREAT_REACHABILITY_TOLERANCE = "High_Threat_Reachability_Tolerance";
        internal const string OVERRUN_AUTO_RESOLVE_MULTIPLE = "Overrun_Auto_Resolve_Multiple";
        internal const string AUTORESOLVEATTRITIONALLOWANCEFACTOR = "AutoResolveAttritionAllowanceFactor";
        internal const string AUTORESOLVETRANSPORTLOSSES = "AutoResolveTransportLosses";
        internal const string AUTORESOLVEDISPLAYTIME = "AutoResolveDisplayTime";
        internal const string RETREATAUTORESOLVELOSERATTRITION = "RetreatAutoResolveLoserAttrition";
        internal const string RETREATAUTORESOLVEWINNERATTRITION = "RetreatAutoResolveWinnerAttrition";
        internal const string AUTORESOLVELOSERATTRITION = "AutoResolveLoserAttrition";
        internal const string AUTORESOLVEWINNERATTRITION = "AutoResolveWinnerAttrition";
        internal const string MINIMUM_TACTICAL_OVERRUN_TIME_IN_SECS = "Minimum_Tactical_Overrun_Time_In_Secs";
        internal const string TACTICAL_OVERRUN_MULTIPLE = "Tactical_Overrun_Multiple";
        internal const string OBJECT_MAX_SPEED_MULTIPLIER_GALACTIC = "Object_Max_Speed_Multiplier_Galactic";
        internal const string OBJECT_MAX_SPEED_MULTIPLIER_SPACE = "Object_Max_Speed_Multiplier_Space";
        internal const string OBJECT_MAX_SPEED_MULTIPLIER_LAND = "Object_Max_Speed_Multiplier_Land";
        internal const string OBJECT_MAX_HEALTH_MULTIPLIER_SPACE = "Object_Max_Health_Multiplier_Space";
        internal const string OBJECT_MAX_HEALTH_MULTIPLIER_LAND = "Object_Max_Health_Multiplier_Land";
        internal const string AUTO_ROTATE_FOR_SPACE_TARGETING = "Auto_Rotate_For_Space_Targeting";
        internal const string AUTO_ADJUST_MOVE_FOR_SPACE_TARGETING = "Auto_Adjust_Move_For_Space_Targeting";
        internal const string IN_GAME_CINEMATICS = "In_Game_Cinematics";
        internal const string PRODUCTION_SPEED_MOD_BASE_VS_TECH_0 = "Production_Speed_Mod_Base_Vs_Tech_0";
        internal const string PRODUCTION_SPEED_MOD_BASE_VS_TECH_1 = "Production_Speed_Mod_Base_Vs_Tech_1";
        internal const string PRODUCTION_SPEED_MOD_BASE_VS_TECH_2 = "Production_Speed_Mod_Base_Vs_Tech_2";
        internal const string PRODUCTION_SPEED_MOD_BASE_VS_TECH_3 = "Production_Speed_Mod_Base_Vs_Tech_3";
        internal const string PRODUCTION_SPEED_MOD_BASE_VS_TECH_4 = "Production_Speed_Mod_Base_Vs_Tech_4";
        internal const string ENGINES_DISABLED_SPEED_MODIFIER = "Engines_Disabled_Speed_Modifier";
        internal const string CROUCH_MOVE_FIRE_ANGLE_CUTOFF = "Crouch_Move_Fire_Angle_Cutoff";
        internal const string MAX_MOVE_FRAME_DELAY = "Max_Move_Frame_Delay";
        internal const string SPREAD_OUT_SPACING_COEFFICIENT = "Spread_Out_Spacing_Coefficient";
        internal const string MAX_FORMATION_AREA = "Max_Formation_Area";
        internal const string SHORT_RANGE_ATTACK_FORMATION_COEFFICIENT = "Short_Range_Attack_Formation_Coefficient";
        internal const string SOLO_ATTACK_RANGE = "Solo_Attack_Range";
        internal const string BASE_LAND_TARGETING_ARC_ANGLE_COEFFICIENT = "Base_Land_Targeting_Arc_Angle_Coefficient";
        internal const string ROTATE_FORMATION_FACING_MOVES = "Rotate_Formation_Facing_Moves";
        internal const string SHOULDUSESPACEIDLEMOVEMENT = "ShouldUseSpaceIdleMovement";
        internal const string SPACEIDLEMOVEMENTSPEED = "SpaceIdleMovementSpeed";
        internal const string SPACEIDLEPATHCULLCOEFFICIENT = "SpaceIdlePathCullCoefficient";
        internal const string IDLEMOVEMENTFRAMES = "IdleMovementFrames";
        internal const string GRIPPERCOMBATGRIDSNAPDISTANCE = "GripperCombatGridSnapDistance";
        internal const string DAMAGE_TYPES = "Damage_Types";
        internal const string ARMOR_TYPES = "Armor_Types";
        internal const string DAMAGE_TO_ARMOR_MOD = "Damage_To_Armor_Mod";
        internal const string UNIT_COMMAND_RANKINGS_BY_CATEGORY = "Unit_Command_Rankings_By_Category";
        internal const string PLANET_ABILITY_ICON_NAMES = "Planet_Ability_Icon_Names";
        internal const string PLANET_ABILITY_TEXT_IDS = "Planet_Ability_Text_IDs";
        internal const string PLANET_ABILITY_RGBS = "Planet_Ability_RGBs";
        internal const string DROID_ENCYCLOPEDIA_OFFSET = "Droid_Encyclopedia_Offset";
        internal const string REINFORCEMENTOVERLAYGOODCOLOR = "ReinforcementOverlayGoodColor";
        internal const string REINFORCEMENTOVERLAYBADCOLOR = "ReinforcementOverlayBadColor";
        internal const string DISPLAY_BINK_MOVIE_FRAMES = "Display_Bink_Movie_Frames";
        internal const string MIN_SKIRMISH_CREDITS = "Min_Skirmish_Credits";
        internal const string MAX_SKIRMISH_CREDITS = "Max_Skirmish_Credits";
        internal const string TACTICAL_BUILD_TIME_MULTIPLIER = "Tactical_Build_Time_Multiplier";
        internal const string SPACE_RETREAT_ATTRITION_FACTOR = "Space_Retreat_Attrition_Factor";
        internal const string LAND_RETREAT_ATTRITION_FACTOR = "Land_Retreat_Attrition_Factor";
        internal const string BLOCKADE_RUN_ATTRITION_FACTOR = "Blockade_Run_Attrition_Factor";
        internal const string TRANSPORT_REFILL_THRESHOLD = "Transport_Refill_Threshold";
        internal const string SQUADRON_REFILL_THRESHOLD = "Squadron_Refill_Threshold";
        internal const string SPACE_TACTICAL_CAMERA_LOCKED = "Space_Tactical_Camera_Locked";
        internal const string LAND_TACTICAL_CAMERA_LOCKED = "Land_Tactical_Camera_Locked";
        internal const string SPACE_COLLIDABLE_GRID_CULL_SIZE = "Space_Collidable_Grid_Cull_Size";
        internal const string LAND_COLLIDABLE_GRID_CULL_SIZE = "Land_Collidable_Grid_Cull_Size";
        internal const string SPACE_LARGE_SHIP_GRID_CULL_SIZE = "Space_Large_Ship_Grid_Cull_Size";
        internal const string RAID_FORCE_FREE_OBJECT_CATEGORY_MASK = "Raid_Force_Free_Object_Category_Mask";
        internal const string RAID_FORCE_LIMITED_OBJECT_CATEGORY_MASK = "Raid_Force_Limited_Object_Category_Mask";
        internal const string RAID_FORCE_MAX_LIMITED_OBJECTS = "Raid_Force_Max_Limited_Objects";
        internal const string RAID_FORCE_MAX_HEROS = "Raid_Force_Max_Heros";
        internal const string RAID_FORCE_REQUIRED_FACTION = "Raid_Force_Required_Faction";
        internal const string WIN_MESSAGE_COLOR = "Win_Message_Color";
        internal const string LOSE_MESSAGE_COLOR = "Lose_Message_Color";
        internal const string WIN_LOSE_MESSAGE_FONT = "Win_Lose_Message_Font";
        internal const string WIN_LOSE_MESSAGE_FONT_SIZE = "Win_Lose_Message_Font_Size";
        internal const string GAME_PLAY_UI_CREDIT_FONT_NAME = "Game_Play_UI_Credit_Font_Name";
        internal const string GAME_PLAY_UI_CREDIT_FONT_SIZE = "Game_Play_UI_Credit_Font_Size";
        internal const string GAME_PLAY_UI_COUNTDOWN_FONT_NAME = "Game_Play_UI_Countdown_Font_Name";
        internal const string GAME_PLAY_UI_COUNTDOWN_FONT_SIZE = "Game_Play_UI_Countdown_Font_Size";
        internal const string IN_GAME_MESSAGE_DEFAULT_FONT_NAME = "In_Game_Message_Default_Font_Name";
        internal const string IN_GAME_MESSAGE_DEFAULT_FONT_SIZE = "In_Game_Message_Default_Font_Size";
        internal const string EVENT_MESSAGE_DEFAULT_FONT_NAME = "Event_Message_Default_Font_Name";
        internal const string EVENT_MESSAGE_DEFAULT_FONT_SIZE = "Event_Message_Default_Font_Size";
        internal const string BINK_PLAYER_CAPTION_FONT_NAME = "Bink_Player_Caption_Font_Name";
        internal const string BINK_PLAYER_CAPTION_FONT_SIZE = "Bink_Player_Caption_Font_Size";
        internal const string TOOL_TIP_FONT_NAME = "Tool_Tip_Font_Name";
        internal const string TOOL_TIP_FONT_SIZE = "Tool_Tip_Font_Size";
        internal const string TOOL_TIP_SMALL_FONT_NAME = "Tool_Tip_Small_Font_Name";
        internal const string TOOL_TIP_SMALL_FONT_SIZE = "Tool_Tip_Small_Font_Size";
        internal const string COMMAND_BAR_DEFAULT_FONT_NAME = "Command_Bar_Default_Font_Name";
        internal const string COMMAND_BAR_DEFAULT_FONT_SIZE = "Command_Bar_Default_Font_Size";
        internal const string TEXT_BUTTON_DEFAULT_FONT_NAME = "Text_Button_Default_Font_Name";
        internal const string TEXT_BUTTON_DEFAULT_FONT_SIZE = "Text_Button_Default_Font_Size";
        internal const string GAME_OBJECT_NAME_FONT_NAME = "Game_Object_Name_Font_Name";
        internal const string GAME_OBJECT_NAME_FONT_SIZE = "Game_Object_Name_Font_Size";
        internal const string BATTLE_PENDING_MESSAGE_COLOR = "Battle_Pending_Message_Color";
        internal const string BATTLE_PENDING_MESSAGE_FONT = "Battle_Pending_Message_Font";
        internal const string BATTLE_PENDING_MESSAGE_FONT_SIZE = "Battle_Pending_Message_Font_Size";
        internal const string BATTLE_PENDING_MESSAGE_POS_X = "Battle_Pending_Message_Pos_X";
        internal const string BATTLE_PENDING_MESSAGE_POS_Y = "Battle_Pending_Message_Pos_Y";
        internal const string MP_DEFAULT_CREDITS = "MP_Default_Credits";
        internal const string MP_DEFAULT_START_TECH_LEVEL = "MP_Default_Start_Tech_Level";
        internal const string MP_DEFAULT_MAX_TECH_LEVEL = "MP_Default_Max_Tech_Level";
        internal const string MP_DEFAULT_ALLOW_AUTO_RESOLVE = "MP_Default_Allow_Auto_Resolve";
        internal const string MP_DEFAULT_GAME_TIMER = "MP_Default_Game_Timer";
        internal const string MP_DEFAULT_WIN_CONDITION = "MP_Default_Win_Condition";
        internal const string MP_DEFAULT_WIN_CONDITION_INT_PARAM = "MP_Default_Win_Condition_Int_Param";
        internal const string MP_DEFAULT_WIN_CONDITION_FLOAT_PARAM = "MP_Default_Win_Condition_Float_Param";
        internal const string MP_DEFAULT_ALLOW_HEROES = "MP_Default_Allow_Heroes";
        internal const string MP_DEFAULT_ALLOW_SUPERWEAPONS = "MP_Default_Allow_SuperWeapons";
        internal const string MP_DEFAULT_PRE_BUILT_BASE = "MP_Default_Pre_Built_Base";
        internal const string MP_DEFAULT_ALLOW_RANDOM_EVENTS = "MP_Default_Allow_Random_Events";
        internal const string MP_DEFAULT_FREE_STARTING_UNITS = "MP_Default_Free_Starting_Units";
        internal const string MP_DEFAULT_LAND_TACTICAL_WIN_CONDITION = "MP_Default_Land_Tactical_Win_Condition";
        internal const string MP_DEFAULT_SPACE_TACTICAL_WIN_CONDITION = "MP_Default_Space_Tactical_Win_Condition";

        internal const string MULTIPLAYER_LOSING_TEAM_BONUS_CREDIT_PERCENTAGE =
            "Multiplayer_Losing_Team_Bonus_Credit_Percentage";

        internal const string MAX_BUILD_QUEUE = "Max_Build_Queue";
        internal const string SPACE_TACTICAL_UNIT_CAP = "Space_Tactical_Unit_Cap";
        internal const string TERRAIN_RESURFACE_RAND = "Terrain_Resurface_Rand";
        internal const string TERRAIN_RESURFACE_TOLERANCE = "Terrain_Resurface_Tolerance";
        internal const string BASE_SHIELD_DELAY_TIME = "Base_Shield_Delay_Time";
        internal const string MIN_GAME_SPEED = "Min_Game_Speed";
        internal const string MAX_GAME_SPEED = "Max_Game_Speed";
        internal const string GAME_SPEED_TRACKBAR_STEPS = "Game_Speed_Trackbar_Steps";
        internal const string OBJECT_IMPORTANCE_DECAY_FACTOR = "Object_Importance_Decay_Factor";
        internal const string UNIT_PRESENCE_RELAXATION_TIME = "Unit_Presence_Relaxation_Time";
        internal const string DEMO_ATTRACT_MAPS = "Demo_Attract_Maps";
        internal const string DEMO_ATTRACT_START_TIMEOUT_SECONDS = "Demo_Attract_Start_Timeout_Seconds";
        internal const string DEMO_ATTRACT_MAP_CYCLE_DELAY_SECONDS = "Demo_Attract_Map_Cycle_Delay_Seconds";
        internal const string BATTLE_PENDING_TIMEOUT_SECONDS = "Battle_Pending_Timeout_Seconds";
        internal const string UNDER_CONSTRUCTION_DAMAGE_MULTIPLIER = "Under_Construction_Damage_Multiplier";
        internal const string SKIRMISH_BUY_CREDITS = "Skirmish_Buy_Credits";
        internal const string SKIRMISH_REINFORCEMENT_DELAY_FRAMES = "Skirmish_Reinforcement_Delay_Frames";
        internal const string DISTRIBUTE_CREDIT_QUANTUM = "Distribute_Credit_Quantum";
        internal const string DIMINISHING_FIREPOWER = "Diminishing_Firepower";
        internal const string ION_STORM_SHIELD_DISABLE_TIME = "Ion_Storm_Shield_Disable_Time";
        internal const string NEBULA_ABILITY_DISABLE_TIME = "Nebula_Ability_Disable_Time";
        internal const string FORCE_ABILITY_DISABLE_TIME = "Force_Ability_Disable_Time";
        internal const string DEPLETED_SHIELD_DISABLE_TIME = "Depleted_Shield_Disable_Time";
        internal const string DEPLETED_SHIELD_DAMAGE_INCREMENT = "Depleted_Shield_Damage_Increment";
        internal const string DEPLETED_SHIELD_REGEN_CAP = "Depleted_Shield_Regen_Cap";
        internal const string NEBULA_EFFECT_COLOR = "Nebula_Effect_Color";
        internal const string BASE_SHIELD_SPEED_MODIFIER = "Base_Shield_Speed_Modifier";
        internal const string BASE_SHIELD_VULNERABILITY_MODIFIER = "Base_Shield_Vulnerability_Modifier";

        internal const string HARDPOINT_RECHARGE_CUTOFF_FOR_OPPORTUNITY_FIRE =
            "Hardpoint_Recharge_Cutoff_For_Opportunity_Fire";

        internal const string BATTLE_LOAD_PLANET_VIEWPORT = "Battle_Load_Planet_Viewport";
        internal const string SALIENCY_SIZE = "Saliency_Size";
        internal const string SALIENCY_POWER = "Saliency_Power";
        internal const string SALIENCY_X = "Saliency_X";
        internal const string SALIENCY_Y = "Saliency_Y";
        internal const string SALIENCY_HEALTH = "Saliency_Health";
        internal const string SALIENCY_TARGETS = "Saliency_Targets";
        internal const string SALIENCY_SPEED = "Saliency_Speed";
        internal const string PLANET_REVEAL_DELAY_TIME = "Planet_Reveal_Delay_Time";
        internal const string BATTLE_LOAD_PLANET_DIRECTION = "Battle_Load_Planet_Direction";
        internal const string BATTLE_LOAD_PLANET_AMBIENT = "Battle_Load_Planet_Ambient";
        internal const string ACTIVATED_BLACK_MARKET_ABILITY_NAMES = "Activated_Black_Market_Ability_Names";
        internal const string ACTIVATED_SLICE_ABILITY_NAMES = "Activated_Slice_Ability_Names";
        internal const string ACTIVATED_SABOTAGE_ABILITY_NAMES = "Activated_Sabotage_Ability_Names";
        internal const string ACTIVATED_NEUTRALIZE_HERO_ABILITY_NAMES = "Activated_Neutralize_Hero_Ability_Names";
        internal const string ACTIVATED_SIPHON_CREDITS_ABILITY_NAMES = "Activated_Siphon_Credits_Ability_Names";
        internal const string ACTIVATED_SYSTEM_SPY_ABILITY_NAMES = "Activated_System_Spy_Ability_Names";
        internal const string ACTIVATED_DESTROY_PLANET_ABILITY_NAMES = "Activated_Destroy_Planet_Ability_Names";
        internal const string ACTIVATED_CORRUPT_PLANET_ABILITY_NAMES = "Activated_Corrupt_Planet_Ability_Names";
        internal const string ACTIVATED_REMOVE_CORRUPTION_ABILITY_NAMES = "Activated_Remove_Corruption_Ability_Names";
        internal const string ACTIVATED_HACK_SUPER_WEAPON_ABILITY_NAMES = "Activated_Hack_Super_Weapon_Ability_Names";
        internal const string USE_REINFORCEMENT_POINTS = "Use_Reinforcement_Points";
        internal const string STRATEGIC_QUEUE_TACTICAL_BATTLES = "Strategic_Queue_Tactical_Battles";
        internal const string HEALTH_BAR_SCALE = "Health_Bar_Scale";
        internal const string LAND_HEALTH_BAR_SCALE = "Land_Health_Bar_Scale";
        internal const string MIN_HEALTH_BAR_SCALE = "Min_Health_Bar_Scale";
        internal const string CREDITS_SPACING = "Credits_Spacing";
        internal const string CREDITS_SCROLL_RATE = "Credits_Scroll_Rate";
        internal const string CREDITS_FONT = "Credits_Font";
        internal const string CREDITS_FONT_SIZE = "Credits_Font_Size";
        internal const string CREDITS_ROWS = "Credits_Rows";
        internal const string CREDITS_TOP_COLOR = "Credits_Top_Color";
        internal const string CREDITS_BOTTOM_COLOR = "Credits_Bottom_Color";
        internal const string CREDITS_HEADER_TOP_COLOR = "Credits_Header_Top_Color";
        internal const string CREDITS_HEADER_BOTTOM_COLOR = "Credits_Header_Bottom_Color";
        internal const string CREDITS_MARGIN = "Credits_Margin";
        internal const string CREDITS_LOGO_1_NAME = "Credits_Logo_1_Name";
        internal const string CREDITS_LOGO_1_WIDTH = "Credits_Logo_1_Width";
        internal const string CREDITS_LOGO_1_HEIGHT = "Credits_Logo_1_Height";
        internal const string CREDITS_LOGO_1_Y_OFFSET = "Credits_Logo_1_Y_Offset";
        internal const string CREDITS_LOGO_2_NAME = "Credits_Logo_2_Name";
        internal const string CREDITS_LOGO_2_WIDTH = "Credits_Logo_2_Width";
        internal const string CREDITS_LOGO_2_HEIGHT = "Credits_Logo_2_Height";
        internal const string CREDITS_LOGO_2_Y_OFFSET = "Credits_Logo_2_Y_Offset";
        internal const string CREDITS_LOGO_3_NAME = "Credits_Logo_3_Name";
        internal const string CREDITS_LOGO_3_WIDTH = "Credits_Logo_3_Width";
        internal const string CREDITS_LOGO_3_HEIGHT = "Credits_Logo_3_Height";
        internal const string CREDITS_LOGO_3_Y_OFFSET = "Credits_Logo_3_Y_Offset";
        internal const string TRACTOR_BEAM_WIDTH = "Tractor_Beam_Width";
        internal const string TRACTOR_BEAM_TEXTURE = "Tractor_Beam_Texture";
        internal const string TRACTOR_BEAM_FRAMES = "Tractor_Beam_Frames";
        internal const string TRACTOR_BEAM_COLOR = "Tractor_Beam_Color";
        internal const string ENERGY_BEAM_WIDTH = "Energy_Beam_Width";
        internal const string ENERGY_BEAM_TEXTURE = "Energy_Beam_Texture";
        internal const string ENERGY_BEAM_FRAMES = "Energy_Beam_Frames";
        internal const string ENERGY_BEAM_COLOR = "Energy_Beam_Color";
        internal const string TEAM_HEALTHBAR_OFFSET = "Team_Healthbar_Offset";

        internal const string OBJECT_VISUAL_STATUS_PARTICLE_ATTACH_BONE_NAMES =
            "Object_Visual_Status_Particle_Attach_Bone_Names";

        internal const string MESSAGE_OF_THE_DAY_URL = "Message_Of_The_Day_URL";

        internal const string CONTROL_POINT_DOMINATION_VICTORY_TIME_IN_SECS =
            "Control_Point_Domination_Victory_Time_In_Secs";

        internal const string CAMERA_FX_MANAGER_LETTERBOX_HEIGHT = "Camera_FX_Manager_Letterbox_Height";
        internal const string HEALTH_LOW_PERCENT_THRESHOLD = "Health_Low_Percent_Threshold";
        internal const string HEALTH_CRITICAL_PERCENT_THRESHOLD = "Health_Critical_Percent_Threshold";
        internal const string MP_COLOR_BLUE = "MP_Color_Blue";
        internal const string MP_COLOR_RED = "MP_Color_Red";
        internal const string MP_COLOR_GREEN = "MP_Color_Green";
        internal const string MP_COLOR_ORANGE = "MP_Color_Orange";
        internal const string MP_COLOR_CYAN = "MP_Color_Cyan";
        internal const string MP_COLOR_PURPLE = "MP_Color_Purple";
        internal const string MP_COLOR_YELLOW = "MP_Color_Yellow";
        internal const string MP_COLOR_GRAY = "MP_Color_Gray";
        internal const string MP_COLOR_EIGHT = "MP_Color_Eight";
        internal const string MELEE_CUTOFF_RANGE = "Melee_Cutoff_Range";
        internal const string SPACE_RETREAT_ALLOWED_COUNTDOWN_SECONDS = "Space_Retreat_Allowed_Countdown_Seconds";
        internal const string LAND_RETREAT_ALLOWED_COUNTDOWN_SECONDS = "Land_Retreat_Allowed_Countdown_Seconds";
        internal const string LOCALIZED_SPLASH_SCREEN = "Localized_Splash_Screen";
        internal const string LOCALIZED_MENU_OVERLAY = "Localized_Menu_Overlay";
        internal const string LOCALIZED_UK_ENGLISH_SPLASH_SCREEN = "Localized_UK_English_Splash_Screen";
        internal const string MAIN_MENU_DEMO_ATTRACT_MODE = "Main_Menu_Demo_Attract_Mode";
        internal const string INDIGENOUS_SPAWN_DESTRUCTION_REWARD = "Indigenous_Spawn_Destruction_Reward";
        internal const string ADVISOR_HINT_INTERVAL = "Advisor_Hint_Interval";
        internal const string ADVISOR_HINT_DURATION = "Advisor_Hint_Duration";
        internal const string RADAR_COLORIZE_SELECTED_UNITS = "Radar_Colorize_Selected_Units";
        internal const string RADAR_SELECTED_UNITS_COLOR = "Radar_Selected_Units_Color";
        internal const string RADAR_COLORIZE_MULTIPLAYER_ENEMY = "Radar_Colorize_Multiplayer_Enemy";
        internal const string RADAR_MULTIPLAYER_ENEMY_COLOR = "Radar_Multiplayer_Enemy_Color";
        internal const string ANIMATE_DURING_GALACTIC_MODE_PAUSE = "Animate_During_Galactic_Mode_Pause";
        internal const string LAND_BASE_DESTRUCTION_FORCES_RETREAT = "Land_Base_Destruction_Forces_Retreat";
        internal const string SPACE_STATION_DESTRUCTION_FORCES_RETREAT = "Space_Station_Destruction_Forces_Retreat";
        internal const string LAND_CAPTURE_ALLOWED_COUNTDOWN_SECONDS = "Land_Capture_Allowed_Countdown_Seconds";
        internal const string SPACE_CAPTURE_ALLOWED_COUNTDOWN_SECONDS = "Space_Capture_Allowed_Countdown_Seconds";

        internal const string SPACE_REINFORCEMENT_COLLISION_CHECK_DISTANCE =
            "Space_Reinforcement_Collision_Check_Distance";

        internal const string HEALTH_BAR_SPACING = "Health_Bar_Spacing";
        internal const string MAX_BOMBING_RUN_INTERVAL_SECONDS = "Max_Bombing_Run_Interval_Seconds";
        internal const string MIN_BOMBING_RUN_INTERVAL_SECONDS = "Min_Bombing_Run_Interval_Seconds";
        internal const string BOMBING_RUN_REDUCTION_PER_SQUADRON_PERCENT = "Bombing_Run_Reduction_Per_Squadron_Percent";
        internal const string MAX_BOMBARD_INTERVAL_SECONDS = "Max_Bombard_Interval_Seconds";
        internal const string MIN_BOMBARD_INTERVAL_SECONDS = "Min_Bombard_Interval_Seconds";
        internal const string BOMBARDMENT_OFFSET = "Bombardment_Offset";
        internal const string BOMBARDMENT_DISTRIBUTION = "Bombardment_Distribution";
        internal const string AI_USES_GALACTIC_POP_CAP = "AI_Uses_Galactic_Pop_Cap";
        internal const string SPACE_GUARD_RANGE = "Space_Guard_Range";
        internal const string LAND_GUARD_RANGE = "Land_Guard_Range";
        internal const string OVERRIDE_DEATH_PERSISTENCE_DURATION = "Override_Death_Persistence_Duration";
        internal const string AUTO_RESOLVE_TACTICAL_MULTIPLIER = "Auto_Resolve_Tactical_Multiplier";
        internal const string QUICKMATCH_MAP_EXCLUSION_LIST = "Quickmatch_Map_Exclusion_List";
        internal const string CORRUPTION_PARTICLE_NAME = "Corruption_Particle_Name";
        internal const string CORRUPTION_PARTICLE_LINE_NAME = "Corruption_Particle_Line_Name";
        internal const string PARTICLE_BRIGHTNESS_PER_CORRUPTION_LEVEL = "Particle_Brightness_Per_Corruption_Level";
        internal const string PARTICLE_SCALE_PER_CORRUPTION_LEVEL = "Particle_Scale_Per_Corruption_Level";
        internal const string PARTICLE_ENERGY_PER_CORRUPTION_LEVEL = "Particle_Energy_Per_Corruption_Level";
        internal const string CORRUPTION_LINE_RADIUS = "Corruption_Line_Radius";
        internal const string CORRUPTION_LINE_START_END_OFFSET = "Corruption_Line_Start_End_Offset";
        internal const string CORRUPTION_LINE_GROW_SECONDS = "Corruption_Line_Grow_Seconds";
        internal const string CORRUPTION_PATH_COLOR = "Corruption_Path_Color";
        internal const string CORRUPTION_PATH_WIDTH = "Corruption_Path_Width";
        internal const string CORRUPTION_PATH_OFFSET = "Corruption_Path_Offset";
        internal const string BRIBERY_FLEET_REVEAL_RANGE = "Bribery_Fleet_Reveal_Range";
        internal const string SABOTAGE_PARTICLE_EFFECT = "Sabotage_Particle_Effect";
        internal const string HACK_SUPER_WEAPON_PARTICLE_EFFECT = "Hack_Super_Weapon_Particle_Effect";
        internal const string HACK_SUPER_WEAPON_REQUIRED_TYPE = "Hack_Super_Weapon_Required_Type";
        internal const string SENSOR_JAMMING_TIME = "Sensor_Jamming_Time";
        internal const string STEALTH_DETECTION_TIME = "Stealth_Detection_Time";
        internal const string FIRST_STRIKE_EXTRA_DAMAGE_PERCENT = "First_Strike_Extra_Damage_Percent";
        internal const string FIRST_STRIKE_PARTICLE = "First_Strike_Particle";
        internal const string GARRISONED_MAX_ATTACK_DISTANCE_MULTIPLIER = "Garrisoned_Max_Attack_Distance_Multiplier";
        internal const string PATHFINDER_SLOT_INDEX = "Pathfinder_Slot_Index";
        internal const string DEFAULT_BOUNTY_BY_CATEGORY_SP = "Default_Bounty_By_Category_SP";
        internal const string DEFAULT_BOUNTY_BY_CATEGORY_MP = "Default_Bounty_By_Category_MP";
        internal const string MAX_REMOTE_BOMBS_PER_PLAYER = "Max_Remote_Bombs_Per_Player";
        internal const string CORRUPTION_HYPERSPACE_BONUS = "Corruption_Hyperspace_Bonus";
        internal const string CORRUPTION_CHOICE_ICON_NAME = "Corruption_Choice_Icon_Name";
        internal const string CORRUPTION_CHOICE_NAME = "Corruption_Choice_Name";
        internal const string CORRUPTION_CHOICE_BENEFIT = "Corruption_Choice_Benefit";
        internal const string CORRUPTION_MISSION_REQUIREMENT_ICON_NAME = "Corruption_Mission_Requirement_Icon_Name";
        internal const string CORRUPTION_CHOICE_ENCYCLOPEDIA = "Corruption_Choice_Encyclopedia";
        internal const string CORRUPTION_CHOICE_INCOME_PERCENTAGE = "Corruption_Choice_Income_Percentage";
        internal const string CORRUPTION_PLANET_ICON = "Corruption_Planet_Icon";
        internal const string CORRUPTION_PLANET_ICON_ENCYCLOPEDIA_NAME = "Corruption_Planet_Icon_Encyclopedia_Name";
        internal const string CORRUPTION_PLANET_ICON_ENCYCLOPEDIA_DESC = "Corruption_Planet_Icon_Encyclopedia_Desc";
        internal const string HACK_SUPER_WEAPON_COST = "Hack_Super_Weapon_Cost";
        internal const string CORRUPTION_ENCYCLOPEDIA_BACKDROP = "Corruption_Encyclopedia_Backdrop";
        internal const string CORRUPTION_ENCYCLOPEDIA_HEADER = "Corruption_Encyclopedia_Header";
        internal const string CORRUPTION_ENCYCLOPEDIA_COMPLETE = "Corruption_Encyclopedia_Complete";
        internal const string CORRUPTION_ENCYCLOPEDIA_INCOMPLETE = "Corruption_Encyclopedia_Incomplete";
        internal const string CORRUPTION_ENCYCLOPEDIA_MONEY_ICON = "Corruption_Encyclopedia_Money_Icon";
        internal const string CORRUPTION_ENCYCLOPEDIA_LEFT_EDGE = "Corruption_Encyclopedia_Left_Edge";
        internal const string CORRUPTION_ENCYCLOPEDIA_SPACING = "Corruption_Encyclopedia_Spacing";
    }
}
