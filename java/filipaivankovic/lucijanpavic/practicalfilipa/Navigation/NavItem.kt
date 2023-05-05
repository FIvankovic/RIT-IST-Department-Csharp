package filipaivankovic.lucijanpavic.practicalfilipa.Navigation

import filipaivankovic.lucijanpavic.practicalfilipa.R

sealed class NavItem(
    var route: String,
    var icon: Int,
    var title: String
) {
    object HomeScreen: NavItem("home", R.drawable.home,"home screen")
    object ListScreen: NavItem("list", R.drawable.list,"list screen")
    object FavoriteScreen: NavItem("favorite", R.drawable.favorite,"favorite screen")
    object MusicScreen: NavItem("music", R.drawable.music,"music screen")

}