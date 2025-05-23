<table>
	<tbody>
		<tr>
			<th align="center">Version</th>
			<th align="center">Notes</th>
		</tr>
		<tr>
			<td align="center">2.0.5</td>
			<td align="left">
				<ul>
					<li>Added center snap points to the end of core wood horizontal logs.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">2.0.4</td>
			<td align="left">
				<ul>
					<li>Reduced logging.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">2.0.3</td>
			<td align="left">
				<ul>
					<li>Fix torch classification bugs.</li>
					<li>Refactoring.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">2.0.2</td>
			<td align="left">
				<ul>
					<li>Adjust snap points on torches in dungeons and those added by MVBP.</li>
					<li>Adjust snap points on rugs to reduce clipping with wood floors.</li>
					<li>Removed unneeded log messages.</li>
					<li>Added support for shudnal's config manager.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">2.0.1</td>
			<td align="left">
				<ul>
					<li>Fixed missing origin snap points on pieces.</li>
					<li>Adjust snap point on portal to reduce clipping with wood floors.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">2.0.0</td>
			<td align="left">
				<ul>
					<li>Added support for named snap points (huge thanks to flo123333 for contributing a ton to that!).</li>
					<li>Added config option to disable Vanilla manual snapping so you don't need to rebind the default cycle snap points keys (disabled by default now).</li>
					<li>Added key hints for cycling placing & target snap points.</li>
					<li>Added key hints for toggling snapping modes.</li>
					<li>Hide key hint regarding using `Shift` to toggle snapping when not in `Auto` snap mode.</li>
					<li>Renamed snapping modes to align with Vanilla snapping mode names.</li>
					<li>Optimized and refactored a lot of code (thanks to flo123333 again for contributing to that as well).</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.4.0</td>
			<td align="left">
				<ul>
					<li>Updated for Bog Witch.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.3.1</td>
			<td align="left">
				<ul>
					<li>Improved warnings in log file for pieces added by mods that cannot have extra snap points added.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.3.0</td>
			<td align="left">
				<ul>
					<li>Updated for Ashlands release.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.2.4</td>
			<td align="left">
				<ul>
					<li>Bugfix to correct typo that broke adding extra snap points.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.2.3</td>
			<td align="left">
				<ul>
					<li>Changed it so snapping mode only changes while in placement mode.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.2.2</td>
			<td align="left">
				<ul>
					<li>Added option to set terrain tools to have snap point or not.</li>
					<li>Minor optimizations.</li>
					<li>Changed removal of extra snap points to prevent possible side-effects.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.2.2</td>
			<td align="left">
				<ul>
					<li>Compiled against newest game version.</li>
					<li>Improves snap points for item stands.</li>
					<li>Update short description to mention world grid snapping.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.2.0/1.2.1</td>
			<td align="left">
				<ul>
					<li>Changed configuration file formatting. <b>You need to regenerate your config file</b>.</li>
					<li>Added Grid Snap mode.</li>
					<li>New icon.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.1.3</td>
			<td align="left">
				<ul>
					<li>Added more configuration options.</li>
					<li>Changed public API to no longer require a string argument.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.1.2</td>
			<td align="left">
				<ul>
					<li>Removed accidental Jotunn dependency due to using a nuget package build file.</li>
					<li>Improved shutdown performance.</li>
					<li>Built against BepInEx 5.4.2202</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.1.1</td>
			<td align="left">
				<ul>
					<li>Improved robustness of classifying pieces as RoofTop pieces. Should hopefully reduce classification errors for non-Vanilla pieces added by other mods.</li>
					<li>Improved shutdown performance.</li>
					<li>Improved automatic classification of torches.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.1.0</td>
			<td align="left">
				<ul>
					<li>Altered internal function of mod to automatically infer the type of build piece and add snap points accordingly.</li>
					<li>Re-wrote mod to dynamically update to config changes while in-game.</li>
					<li>Improved interactions with MoreVanillaBuildPrefabs and other mods that add build pieces.</li>
					<li>Added option to disable adding extra snap points for all pieces at once.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.0.6</td>
			<td align="left">
				<ul>
					<li>Update for patch 0.217.25</li>
					<li>Slight improvements in load times.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.0.5</td>
			<td align="left">
				<ul>
					<li>Fixed null excpetion error caused when in manual snap mode and switching to place pieces that have no snap points.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.0.4</td>
			<td align="left">
				<ul>
					<li>Added a built-in config file watcher to ensure configuration changes are not lost.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.0.3</td>
			<td align="left">
				<ul>
					<li>Speed up inital load time slightly.</li>
					<li>Added prefabs from MoreVanillaBuildPrefabs that will be ignored.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.0.1/1.0.2</td>
			<td align="left">
				<ul>
					<li>Update for patch 0.217.22</li>
					<li>Added snap points to new build piece.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">1.0.0</td>
			<td align="left">
				<ul>
					<li>Feature complete release.</li>
					<li>Added snap points to all build pieces with the option to enable/disable snap points on a piece by piece basis.</li>
					<li>Added Manual (Closest) snapping mode.</li>
				</ul>
			</td>
		</tr>
		<tr>
			<td align="center">0.0.1/0.0.2</td>
			<td align="left">
				<ul>
					<li>
						Initial release and README updates.
					</li>
				</ul>
			</td>
		</tr>
	</tbody>
</table>