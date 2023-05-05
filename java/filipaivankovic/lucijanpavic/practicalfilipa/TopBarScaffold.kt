package filipaivankovic.lucijanpavic.practicalfilipa

import androidx.compose.material.*
import androidx.compose.runtime.Composable
import kotlinx.coroutines.CoroutineScope
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.unit.sp

@Composable
fun TopBarScaffold(scope: CoroutineScope, scaffoldState: ScaffoldState) {
    TopAppBar(
        title = {
            Text(
                text = stringResource(id = R.string.app_name),
                fontSize = 18.sp
            )
        },
        backgroundColor = MaterialTheme.colors.primary,
        contentColor = Color.White
    )
} // TopBar